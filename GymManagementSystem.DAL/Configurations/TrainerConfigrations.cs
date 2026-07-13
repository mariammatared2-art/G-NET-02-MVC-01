using GymManagementSystem.DAL.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymManagementSystem.DAL.Configurations
{
    internal class TrainerConfigrations : GymUserConfigrations<Trainer> , IEntityTypeConfiguration<Trainer>
    {
        public void configure(EntityTypeBuilder<Trainer> builder)
        {
            builder.Property(T => T.CreatedAt)
                .HasColumnName("HireDate")
                .HasDefaultValueSql("GetDate()");
            base.Configure(builder);
        }
    }
}
