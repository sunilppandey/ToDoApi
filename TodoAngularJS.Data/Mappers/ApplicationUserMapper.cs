using Contact.Data.Mappers;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TodoAngularJS.Data.Entities;

namespace TodoAngularJS.Data.Mappers
{
    class ApplicationUserMapper : EntityTypeConfiguration<ApplicationUser>
    {
        public ApplicationUserMapper()
        {
            this.ToTable("AspNetUsers", "Users");

            this.HasKey(c => c.Id);
            this.Property(c => c.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            this.Property(c => c.Id).IsRequired();

            this.Property(c => c.FirstName).IsRequired();
            this.Property(c => c.FirstName).HasMaxLength(100);

            this.Property(c => c.FirstName).IsRequired();
            this.Property(c => c.FirstName).HasMaxLength(100);

            this.Property(c => c.LastName).IsRequired();
            this.Property(c => c.LastName).HasMaxLength(100);

            this.Property(c => c.Level).IsRequired();

            this.Property(c => c.JoinDate).IsRequired();
        }
    }
}
