using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//business logic
namespace EcoScooter.Entities
{
    public partial class Rental
    {
        public Rental()
        {
            this.TrackPoints = new List<TrackPoint>();
        }
        public Rental(DateTime? EndDate, Decimal Price, DateTime StartDate,
                       Station OriginStation, Scooter Scooter, User User) : this()
        {
            this.EndDate = EndDate;
            this.Price = Price;
            this.StartDate = StartDate;
            this.OriginStation = OriginStation;
            this.Scooter = Scooter;
            this.User = User;

        }

        public void SetUser(User userAlquila)
        {
            this.User = userAlquila;
        }

        public void SetScooter(Scooter scooterAlquila)
        {
            this.Scooter = scooterAlquila;

        }

        public void SetOriginStation(Station originStation)
        {
            this.OriginStation = originStation;
        }

        public int getScooterId()
        {
            return this.Scooter.getId();
        }

        public void ScooterStateAvailable()
        {
            this.Scooter.Available();
        }

        public void SetDestinationStation(Station destinationStation)
        {
            this.DestinationStation = destinationStation;
        }


        public void SetPrice(decimal price)
        {
            this.Price = price;
        }

        public void SetEndDate(DateTime endDate)
        {
            this.EndDate = endDate;
        }


        public bool EqualsRental(int rentalID)
        {
            if (this.Id.Equals(rentalID))
                return true;
            else
                return false;

        }

        public void GenerateIncident(string description, DateTime timeStamp)

        {
            Incident incident = new Incident(description, timeStamp);
            this.Incident = incident;
        }


        public void GenerateId()
        {
            Random random = new Random();
            int randomNumber = random.Next(0, 10000); //lo podemos hacer asi? olo hacemos con un contador
            this.Id = randomNumber;
        }

        public double GetTime(DateTime endtime)
        {
            return this.StartDate.Subtract(endtime).Minutes;
        }


        public void UpdateRental(Station destinationStation, User loggedUser, Rental rental, EcoScooter ecoScooter)
        {
            

            this.DestinationStation = destinationStation;
            this.EndDate = DateTime.Now;
            this.Price = ecoScooter.CalculatePrice((DateTime)this.EndDate, this.StartDate, loggedUser.getAge());
           
            if (loggedUser.getAge() <= 25)
                this.Price = ecoScooter.CalculateDiscount(this.Price);

            this.Scooter.StateAvailable(destinationStation);

            destinationStation.AddDestinationRental(rental);
            destinationStation.AddScooter(this.Scooter);
        }

        public DateTime getStartDate()
        {
            return this.StartDate;
        }

        public DateTime? getEndDate()
        {
            return this.EndDate;
        }

      


        public static bool ValidIntervalDates(DateTime startDate, DateTime endDate)
        {
            if (startDate <= endDate)
                return true;

            else
                return false;
        }

        public string getIdinString()
        {
            return this.Id.ToString();
        }

        public decimal getPrice()
        {
            return this.Price;
        }

        public string getOriginStation()
        {
            return this.OriginStation.getId();
        }

        public string getDestinationStation()
        {
            return this.DestinationStation.getId();
        }


        public string getInfo()
        {
            //return "Fecha inicio: " + this.StartDate + "," +
            //       "Fecha fin: " + this.EndDate + "," +
            //       "Precio: " + this.Price + "," +
            //       "Estacion de origen (id): " + this.OriginStation.getId() + "," +
            //       "Estacion de destino (id): " + this.DestinationStation.getId() ;

            return   this.StartDate + "," + this.EndDate + ","  + this.Price + "," 
                    + this.OriginStation.getId() + "," + this.DestinationStation.getId();
        }
    }
}
