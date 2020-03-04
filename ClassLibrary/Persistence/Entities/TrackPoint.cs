using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//persistence
namespace EcoScooter.Entities
{
    public partial class TrackPoint
    {
        public int Id
        {
            get;
            set;
        }

        public Double BatteryLevel
        {
            set;
            get;
        }
        public Double Latitude
        {
           
            set;
            get;
        }
        public Double Longitude { 
        
            set;
            get;
        }
        public Double Speed
        {
            
            set;
            get;
        }
        public DateTime Timestamp { 
        
            set;
            get;
        }
    }
}
