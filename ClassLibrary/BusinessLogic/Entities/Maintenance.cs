using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//business logic

namespace EcoScooter.Entities
{
    public partial class Maintenance
    {
        public Maintenance()
        {
            this.PlanningWork = new List<PlanningWork>();
        }
        public Maintenance(String Description, DateTime? EndDate, DateTime StartDate,
                            Employee Employee):this() //se relaja Planning Work por lo que no se coloca en el constructor
        {
            this.Description = Description;
            this.StartDate = StartDate;
            this.EndDate = EndDate;
            this.Employee = Employee;
            

        }
    }
}
