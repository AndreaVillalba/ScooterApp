using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//persistence
namespace EcoScooter.Entities
{
    public partial class Employee:Person
    {
        public String Iban
        {
            get;
            set;
        }

        public int Pin {
            get;
            set;
        }

        public string Position
        {
            get;
            set;
        }

        public Decimal Salary
        {
            get;
            set;
        }

       //relaciones
       public virtual ICollection<Maintenance> Maintenances
        {
            get;
            set;
        }

    }
}
