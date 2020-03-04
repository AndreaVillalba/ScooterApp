using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//persistence
namespace EcoScooter.Entities
{
    public partial class Scooter
    {
        public int Id
        {
            get;
            set;

        }

        public DateTime RegisterDate
        {
            get;
            set;
        }
        public ScooterState State{
            get;
            set;
        }
    //(como se crea una clase separada con literales)

        /*relaciones*/
        public virtual ICollection<Rental> Rentals
        {
            get;
            set;
        }
        public virtual ICollection<PlanningWork> PlanningWork
        {
            get;
            set;
        }
        public virtual Maintenance Maintenance
        {
            get;
            set;
        }
        public virtual Station Station
        {
            get;
            set;
        }
    }
}
