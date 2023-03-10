// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using Recap.DataAccess.EntityFramework.Context;

#nullable disable

namespace RecapUI.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20230227180425_6")]
    partial class _6
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.13")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("Recap.Entities.Category", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid")
                        .HasColumnName("Id");

                    b.Property<string>("CreatedADUserName")
                        .HasColumnType("text")
                        .HasColumnName("Oluşturan Yönetici Adı");

                    b.Property<string>("CreatedBy")
                        .HasColumnType("text")
                        .HasColumnName("Oluşturan Kişi");

                    b.Property<string>("CreatedComputerName")
                        .HasColumnType("text")
                        .HasColumnName("Oluşturanın Bilgisayar Adı");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("Oluşturulma Zamanı");

                    b.Property<string>("CreatedDomainName")
                        .HasColumnType("text")
                        .HasColumnName("Oluşturanın Bilgisayarının Domain Adı");

                    b.Property<string>("CreatedIp")
                        .HasColumnType("text")
                        .HasColumnName("Oluşturan Ip");

                    b.Property<Guid?>("MasterId")
                        .HasColumnType("uuid");

                    b.Property<string>("ModifiedADUserName")
                        .HasColumnType("text")
                        .HasColumnName("Güncelleyen Yönetici Adı");

                    b.Property<string>("ModifiedBy")
                        .HasColumnType("text")
                        .HasColumnName("Güncelleyen Kişi");

                    b.Property<string>("ModifiedComputerName")
                        .HasColumnType("text")
                        .HasColumnName("Güncelleyen Bilgisayar Adı");

                    b.Property<DateTime>("ModifiedDate")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("Güncelleyen Zamanı");

                    b.Property<string>("ModifiedDomainName")
                        .HasColumnType("text")
                        .HasColumnName("Güncelleyen Bilgisayarının Domain Adı");

                    b.Property<string>("ModifiedIp")
                        .HasColumnType("text")
                        .HasColumnName("Güncelleyen Ip");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("character varying(50)");

                    b.Property<int>("Status")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.ToTable("categories", (string)null);
                });

            modelBuilder.Entity("Recap.Entities.Product", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid")
                        .HasColumnName("Id");

                    b.Property<Guid>("CategoryId")
                        .HasColumnType("uuid");

                    b.Property<string>("CreatedADUserName")
                        .HasColumnType("text")
                        .HasColumnName("Oluşturan Yönetici Adı");

                    b.Property<string>("CreatedBy")
                        .HasColumnType("text")
                        .HasColumnName("Oluşturan Kişi");

                    b.Property<string>("CreatedComputerName")
                        .HasColumnType("text")
                        .HasColumnName("Oluşturanın Bilgisayar Adı");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("Oluşturulma Zamanı");

                    b.Property<string>("CreatedDomainName")
                        .HasColumnType("text")
                        .HasColumnName("Oluşturanın Bilgisayarının Domain Adı");

                    b.Property<string>("CreatedIp")
                        .HasColumnType("text")
                        .HasColumnName("Oluşturan Ip");

                    b.Property<Guid?>("MasterId")
                        .HasColumnType("uuid");

                    b.Property<string>("ModifiedADUserName")
                        .HasColumnType("text")
                        .HasColumnName("Güncelleyen Yönetici Adı");

                    b.Property<string>("ModifiedBy")
                        .HasColumnType("text")
                        .HasColumnName("Güncelleyen Kişi");

                    b.Property<string>("ModifiedComputerName")
                        .HasColumnType("text")
                        .HasColumnName("Güncelleyen Bilgisayar Adı");

                    b.Property<DateTime>("ModifiedDate")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("Güncelleyen Zamanı");

                    b.Property<string>("ModifiedDomainName")
                        .HasColumnType("text")
                        .HasColumnName("Güncelleyen Bilgisayarının Domain Adı");

                    b.Property<string>("ModifiedIp")
                        .HasColumnType("text")
                        .HasColumnName("Güncelleyen Ip");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("character varying(50)");

                    b.Property<string>("QuantityPerUnit")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("character varying(50)");

                    b.Property<int>("Status")
                        .HasColumnType("integer");

                    b.Property<decimal>("UnitPrice")
                        .HasColumnType("numeric");

                    b.Property<int>("UnitsInStock")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.ToTable("products", (string)null);
                });

            modelBuilder.Entity("Recap.Entities.User", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid")
                        .HasColumnName("Id");

                    b.Property<int>("Age")
                        .HasColumnType("integer");

                    b.Property<string>("Country")
                        .HasMaxLength(50)
                        .HasColumnType("character varying(50)");

                    b.Property<string>("CreatedADUserName")
                        .HasColumnType("text")
                        .HasColumnName("Oluşturan Yönetici Adı");

                    b.Property<string>("CreatedBy")
                        .HasColumnType("text")
                        .HasColumnName("Oluşturan Kişi");

                    b.Property<string>("CreatedComputerName")
                        .HasColumnType("text")
                        .HasColumnName("Oluşturanın Bilgisayar Adı");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("Oluşturulma Zamanı");

                    b.Property<string>("CreatedDomainName")
                        .HasColumnType("text")
                        .HasColumnName("Oluşturanın Bilgisayarının Domain Adı");

                    b.Property<string>("CreatedIp")
                        .HasColumnType("text")
                        .HasColumnName("Oluşturan Ip");

                    b.Property<char>("Gender")
                        .HasColumnType("character(1)");

                    b.Property<Guid?>("MasterId")
                        .HasColumnType("uuid");

                    b.Property<string>("ModifiedADUserName")
                        .HasColumnType("text")
                        .HasColumnName("Güncelleyen Yönetici Adı");

                    b.Property<string>("ModifiedBy")
                        .HasColumnType("text")
                        .HasColumnName("Güncelleyen Kişi");

                    b.Property<string>("ModifiedComputerName")
                        .HasColumnType("text")
                        .HasColumnName("Güncelleyen Bilgisayar Adı");

                    b.Property<DateTime>("ModifiedDate")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("Güncelleyen Zamanı");

                    b.Property<string>("ModifiedDomainName")
                        .HasColumnType("text")
                        .HasColumnName("Güncelleyen Bilgisayarının Domain Adı");

                    b.Property<string>("ModifiedIp")
                        .HasColumnType("text")
                        .HasColumnName("Güncelleyen Ip");

                    b.Property<string>("Name")
                        .HasMaxLength(50)
                        .HasColumnType("character varying(50)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("Status")
                        .HasColumnType("integer");

                    b.Property<string>("Surname")
                        .HasMaxLength(50)
                        .HasColumnType("character varying(50)");

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("character varying(50)");

                    b.HasKey("Id");

                    b.ToTable("users", (string)null);
                });

            modelBuilder.Entity("Recap.Entities.Product", b =>
                {
                    b.HasOne("Recap.Entities.Category", "Category")
                        .WithMany("Products")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");
                });

            modelBuilder.Entity("Recap.Entities.Category", b =>
                {
                    b.Navigation("Products");
                });
#pragma warning restore 612, 618
        }
    }
}
