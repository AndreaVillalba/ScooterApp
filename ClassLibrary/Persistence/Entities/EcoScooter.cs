using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//persistence

namespace EcoScooter.Entities
{
    public partial class EcoScooter
    {
        public int Id
        {
            get;
            set;
        }

        public Double DiscountYounger 
        {
            get;
            set;
        }
        public Double Fare
        {
            get;
            set;
        }
        public Double MaxSpeed
        {
            get;
            set;
        }

        /*Relaciones*/
        public virtual ICollection<Person>People
        {
            get;
            set;
        }
        public virtual ICollection<Scooter> Scooters
        {
            get;
            set;
        }

        public virtual ICollection<Station> Stations
        {
            get;
            set;
        }
        public virtual ICollection<Employee> Employees
        {
            get;
            set;
        }
    }

}
