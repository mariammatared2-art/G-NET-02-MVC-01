using GymManagementSystem.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GymManagementSystem.Configrations
{
    public class PlanConfiguration : IEntityTypeConfiguration<Plan>
    {
        public void Configure(EntityTypeBuilder<Plan> builder)
        {
            builder.Property(P => P.Name)
                .HasColumnType("Varchar")
                .HasMaxLength(50);
            builder.Property(P => P.Description)
                .HasMaxLength (200);
            builder.Property(P => P.Price)
                .HasPrecision (10,2);
            builder.Property(P => P.CreateAt)
                .HasDefaultValueSql("GetDate()");
            builder.ToTable(TB =>
            {
                TB.HasCheckConstraint("PlanDurationCheck", "DurationDays Between 1 and 365");
            });
        }
    }
}
