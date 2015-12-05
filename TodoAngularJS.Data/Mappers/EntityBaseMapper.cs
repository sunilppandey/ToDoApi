using Contact.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.ModelConfiguration;

namespace Contact.Data.Mappers
{
    // Mapper or configuration
    public class EntityBaseMapper<T> : EntityTypeConfiguration<T> where T : class, IEntityBase
    {
        public EntityBaseMapper()
        {
            HasKey(c => c.Id);
        }
    }
}
