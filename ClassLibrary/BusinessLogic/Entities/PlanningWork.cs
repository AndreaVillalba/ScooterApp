using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//business logic
namespace EcoScooter.Entities
{
    public partial class PlanningWork
    {
        public PlanningWork()
        {

        }

        public PlanningWork(String Description, int WorkingTime, Maintenance Maintenance, Scooter Scooter )
        {
            this.Description = Description;
            this.WorkingTime = WorkingTime;
            this.Maintenance = Maintenance;
            this.Scooter = Scooter;
        }
    }
}
