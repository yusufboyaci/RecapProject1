﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using Recap.Core.Entity;
using Recap.Core.Methods;
using Recap.Entities;
using Recap.Entities.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace Recap.DataAccess.EntityFramework.Context
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new CategoryMap());
            modelBuilder.ApplyConfiguration(new ProductMap());
            base.OnModelCreating(modelBuilder);
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql("server=localhost;port=5432;database=RecapProject1Db;uid=postgres;pwd=123");
            base.OnConfiguring(optionsBuilder);
        }
        public override int SaveChanges()
        {
            NetworkFunctions networkFunctions = new NetworkFunctions();
            List<EntityEntry> modifiedEntries = ChangeTracker.Entries().Where(x => x.State == EntityState.Added || x.State == EntityState.Modified).ToList();
            string identity = WindowsIdentity.GetCurrent().Name;
            string computerName = Environment.MachineName;
            DateTime dateTime = DateTime.Now.ToUniversalTime();//"Cannot write DateTime with Kind=Local to PostgreSQL type 'timestamp with time zone', only UTC is supported." hatasını çözmek için kullanıldı.
            string user = Environment.UserName;
            string ip = networkFunctions.GetLocalIpAddress();
            string domainName = Environment.UserDomainName;

            modifiedEntries.ForEach(item =>
            {
                CoreEntity? entity = item.Entity as CoreEntity;
                if (entity != null)
                {
                    if (item.State == EntityState.Added)
                    {
                        entity.CreatedADUserName = identity;
                        entity.CreatedComputerName = computerName;
                        entity.CreatedDate = dateTime;
                        entity.CreatedIp = ip;
                        entity.CreatedBy = user;
                        entity.CreatedDomainName = domainName;
                    }
                    else if (item.State == EntityState.Modified)
                    {
                        entity.ModifiedADUserName = identity;
                        entity.ModifiedComputerName = computerName;
                        entity.ModifiedDate = dateTime;
                        entity.ModifiedIp = ip;
                        entity.ModifiedBy = user;
                        entity.ModifiedDomainName = domainName;
                    }
                }
            });
            return base.SaveChanges();
        }
    }
}
