using GymManagementSystem.Configrations;
using GymManagementSystem.Models;
using Microsoft.EntityFrameworkCore;

namespace GymManagementSystem.DbContexts
{
    #region GymDbContext
    public class GymDbContext : DbContext
    {
        public GymDbContext(DbContextOptions<GymDbContext> options) : base(options) 
        {
        }

        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    optionsBuilder.UseSqlServer("Server=.;Database=GymDbG02;Trusted_Connection=True;TrustServerCertificate=True");
        //}
        public DbSet<Plan> Plans { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new PlanConfigurations());
        }
    }
    #endregion
}
