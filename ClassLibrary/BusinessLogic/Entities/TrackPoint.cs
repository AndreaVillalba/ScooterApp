using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// business logic 
namespace EcoScooter.Entities
{
    public partial class TrackPoint
    {
        public TrackPoint()
        {

        }

        public TrackPoint(Double BatteryLevel, Double Latitude, Double Longitude, Double Speed,  DateTime Timestamp)
        {
            
                this.BatteryLevel = BatteryLevel;
                this.Latitude = Latitude;
                this.Longitude = Longitude;
                this.Speed = Speed;
                this.Timestamp = Timestamp;
            
        }
    }
    
}
