using GymManagementSystem.DAL.Repositories.Classes;
using GymManagementSystem.DAL.Repositories.Interfaces;
using GymManagementSystem.DbContexts;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace GymManagementSystem.Controllers
{
    #region Plans
    public class PlansController : Controller
    {
        private readonly IPlanRepository _planRepo;
        private readonly GymDbContext _dbContext;
        public PlansController(IPlanRepository planrepo )
        {
            //_planRepo = new PlanRepository();
            _planRepo= planrepo;
        }
        public async Task<IActionResult> Index(CancellationToken ct )
        {
            var plans = await _planRepo.GetALLAsync(ct: ct);
            return View(plans);
        }
        public async Task<IActionResult> Details(int id , CancellationToken ct)
        {
            var plan = await _planRepo.GetByIdAsync(id , ct );
            if (plan == null)
            {
                return RedirectToAction(nameof(Index));
            }
            return View(plan);
        }
    }
    #endregion
}
