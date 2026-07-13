using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymManagementSystem.DAL.Models
{
    internal class Member : GymUser
    {
        public string Photo { get; set; } = default!;

    }
}
