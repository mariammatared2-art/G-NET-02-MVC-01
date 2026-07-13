using GymManagementSystem.DAL.Repositories.Interfaces;
using GymManagementSystem.DbContexts;
using GymManagementSystem.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymManagementSystem.DAL.Repositories.Classes
{
    public class PlanRepository : IPlanRepository
    {
        private readonly GymDbContext _dbContext;
        public PlanRepository(GymDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public async Task<IEnumerable<Plan>> GetALLAsync(bool tracking = false, CancellationToken ct = default)
        {
            var plans = tracking ? _dbContext.Plans.ToListAsync(ct): _dbContext.Plans.AsNoTracking().ToListAsync(ct);
            return await plans;
        }

        public async Task<Plan?> GetByIdAsync(int id, CancellationToken ct = default)
        {
            var plan = _dbContext.Plans.FindAsync( id , ct);
            return await plan;
        }
        public async Task<int> AddAsync(Plan plan, CancellationToken ct = default)
        {
           _dbContext.Plans.Add(plan);
          return await _dbContext.SaveChangesAsync(ct);
        }

        public async Task<int> DeleteAsync(Plan plan, CancellationToken ct = default)
        {
          _dbContext.Plans.Update(plan);
            return await _dbContext.SaveChangesAsync(ct);
        }

        

        public async Task<int> UpdateAsync(Plan plan, CancellationToken ct = default)
        {
            _dbContext.Plans.Remove(plan);
            return await _dbContext.SaveChangesAsync(ct); 
        }
    }
}
