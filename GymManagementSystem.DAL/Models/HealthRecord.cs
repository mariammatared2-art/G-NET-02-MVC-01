using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymManagementSystem.DAL.Models
{
    public class HealthRecord : BaseEntity
    {
        public int Height { get; set; }
        public int weight { get; set; }
        public string Note { get; set; } = default!;
        public string BloodType { get; set; } = default!;

    }
}
