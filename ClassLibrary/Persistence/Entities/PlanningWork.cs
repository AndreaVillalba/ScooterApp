using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//persistence
namespace EcoScooter.Entities
{
    public partial class PlanningWork
    {

        public int Id
        {
            get;
            set;
        }
        public String Description
        {
            get;
            set;
        }

        public int WorkingTime
        {
            get;
            set;
        }

        //relaciones
        public virtual Maintenance Maintenance
        {
            get;
            set;
        }

        public virtual Scooter Scooter
        {
            get;
            set;
        }
    }
}
