using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//business logic
namespace EcoScooter.Entities
{
    public partial class Scooter
    {
        
        public Scooter()
        {
            this.PlanningWork = new List<PlanningWork>();
            this.Rentals = new List<Rental>();

        }
        public Scooter(DateTime RegisterDate, ScooterState State)
        {
            this.RegisterDate = RegisterDate;
            this.State = State;

            this.PlanningWork = new List<PlanningWork>();
            this.Rentals = new List<Rental>();


        }

   
        public void SetStation(Station station)
        {
            this.Station = station;
        }

        public bool IsStateAvailable(ScooterState state)
        {
            if (state==ScooterState.available)
          {
               return true;
            }
          return false;
        }

        public void Available()
        {
            this.State = ScooterState.available;
        }

        public static bool ValidRegisterDate(DateTime rdate)
        {
            if (rdate<=(DateTime.Now))
                return true;
            else
                return false;
        }

        public static bool ValidState(ScooterState state)
        {
            if (state != null)
                return true;
           
            else
                return false;
        }

        public void AddRental(Rental rental)
        {
            Rentals.Add(rental);
        }
        //public void AssignStation(Station station, Scooter scooter)
        //{
        //    //scooter.
        //}
        public int getId()
        {
            return this.Id;
        }

        public void StateInUse()
        {
            this.State = ScooterState.inUse;
            this.Station = null;
        }

        public void StateAvailable(Station destinationStation)
        {
            this.State = ScooterState.available;
            this.Station = destinationStation;
        }





    }
}
