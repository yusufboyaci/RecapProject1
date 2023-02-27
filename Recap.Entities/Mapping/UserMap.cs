using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Recap.Core.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recap.Entities.Mapping
{
    public class UserMap:CoreMap<User>
    {
        public override void Configure(EntityTypeBuilder<User> builder)
        {
            builder.ToTable("users");
            builder.Property(x => x.Username).HasMaxLength(50).IsRequired(true);
            builder.Property(x => x.Name).HasMaxLength(50).IsRequired(false);
            builder.Property(x => x.Surname).HasMaxLength(50).IsRequired(false);
            builder.Property(x => x.Country).HasMaxLength(50).IsRequired(false);
            base.Configure(builder);
        }
    }
}
