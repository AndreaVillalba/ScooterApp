using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcoScooter.Entities
{
    public partial class Station
    {
        public Station()
        {
            this.DestinationRentals = new List<Rental>();
            this.OriginRentals = new List<Rental>();
            this.Scooters = new List<Scooter>();
        }

        public Station(String Address, String Id, Double Latitude, Double Longitude):this()
        {
           
                this.Address = Address;
                this.Id = Id;
                this.Latitude = Latitude;
                this.Longitude = Longitude;
   
        }
        public Scooter GetFirstScooter()
        {
            if (Scooters.Count() != 0)
                return Scooters.First();
            else
                return null;
        }

        public void DeleteFirstScooter(Scooter scooter)
        {
            Scooters.Remove(Scooters.First()); //ayuda esto o el objeto scooter
            scooter.StateInUse();
        }

        public void AddDestinationRental(Rental rental)
        {
            DestinationRentals.Add(rental);
        }

        public bool IsAvailable()
        {

            return Scooters.Count > 0;

        }


        public bool EqualsStation(string id_station)
        {

            if (id_station == this.Id)
            {
                return true;
            }
            return false;
        }

        public void AddScooter(Scooter scooter)
        {
            Scooters.Add(scooter);
        }

        public static bool ValidAddress(string Address)
        {
            if (Address.Length!=0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool GPSLat(double Latitude)
        {
            if (Latitude >= -90 && Latitude<=90)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static bool GPSLon(double Longitude)
        {
            if (Longitude >= -180 && Longitude<=180)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool ValidationStatId(String Id)
        {
            if (Id != null)
            {
                return true;
            }
            else
            {
                return false;
            }

           
        }

        public void AddOriginRental(Rental rental)
        {
           OriginRentals.Add(rental);
        }

        public string getId()
        {
            return this.Id;
        }
    }
}
