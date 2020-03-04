using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//persistence
namespace EcoScooter.Entities
{
    public partial class Station
    {
       public String Address
        {
            get;
            set;
        }
       public String Id
        {
            get;
            set;

        }

        public Double Latitude
        {
            get;
            set;
        }
        public Double Longitude
        {
            get;
            set;
        }
        //relaciones
        public virtual ICollection<Rental> DestinationRentals
        {
            get;
            set;
        }

        public virtual ICollection<Rental> OriginRentals
        {
            get;
            set;
        }
        public virtual ICollection<Scooter> Scooters
        {
            get;
            set;
        }

   
    }
}
