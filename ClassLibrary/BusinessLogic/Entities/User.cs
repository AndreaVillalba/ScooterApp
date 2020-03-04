using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EcoScooter.Services;
using EcoScooter.Persistence;
//business logic
namespace EcoScooter.Entities
{
    public partial class User : Person
    {
        public User()
        {
            this.Rentals = new List<Rental>();
        }

        public User(DateTime Birthdate, String Dni, String Email, String Name, int Telephon, int Cvv,
                    DateTime ExpirationDate, String Login, int Number, String Password) : base(Birthdate, Dni, Email, Name, Telephon)
        {
            this.Cvv = Cvv;
            this.ExpirationDate = ExpirationDate;
            this.Login = Login;
            this.Number = Number;
            this.Password = Password;
            this.Rentals = new List<Rental>();
        }

        public void AddRental( Station OriginStation, Scooter scooter, User User)
        {
            DateTime? EndDate = null;
            Decimal Price = 0;
            DateTime StartDate = DateTime.Now;

            Rental rental = new Rental(EndDate, Price, StartDate, OriginStation, scooter, User);
            Rentals.Add(rental);

            scooter.AddRental(rental); //no se si hay que ponerlo
            OriginStation.AddOriginRental(rental);
            OriginStation.DeleteFirstScooter(scooter);
           // Scooter.StateInUse();

        }
        public static bool ValidCVV(int cvv)
        {

            if (cvv.ToString().Length == 3)
                return true;
            else
                return false;

        }

        public Rental GetActualRental()
        {
           // return Rentals.Last().EndDate=null;

            foreach (Rental rental in Rentals)
            {
                if (rental.EndDate == null)
                {
                    return rental;

                }
            }
            return null;

        }

        public string GetLastRentalId()
        {

            return Rentals.Last().getIdinString();
        }

        

        public Rental GetRentalbyID(int rentalID)
        {
            //return Rentals.Last();

            foreach (Rental rental in Rentals)
            {
                if (rental.EqualsRental(rentalID))
                {
                    return rental;

                }
            }
            return null;

        }

        public ICollection<string> GetRentalsId(DateTime startdate, DateTime endDate)
        {
            List<string> RentalsID = new List<string>();
            foreach (Rental rental in Rentals)
            {
                if (rental.getStartDate()>=startdate && rental.getEndDate()<= endDate)
                {
                    RentalsID.Add(rental.getIdinString());
                }

            }
            return RentalsID;
        }

        //public ICollection<string> GetRentalsInfo(DateTime startdate, DateTime endDate)
        //{
        //    List<string> RentalsInfo = new List<string>();
        //    foreach (Rental rental in Rentals)
        //    {
        //        if (rental.getStartDate() >= startdate && rental.getEndDate() <= endDate)
        //        {
        //            RentalsInfo.Add(rental.getInfo());
        //        }

        //    }
        //    return RentalsInfo;
        //}


        public int getAge()
        {
            int age = DateTime.Now.Year - this.Birthdate.Year;

            if (DateTime.Now.Month < this.Birthdate.Month || DateTime.Now.Month == this.Birthdate.Month && DateTime.Now.Day < this.Birthdate.Day)
                age--;

            return age;
        }



        public static bool ValidCardNumber(int number)
        {
            if (number.ToString().Length == 8)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool ValidExpirationDate(DateTime expirationDate)
        {
           if (expirationDate >= DateTime.Now)
               return true;
            else
                return false;

       }

        public bool EqualsUserName(string login)
        {
            if (this.Login.Equals(login))
                return true;
            else
                return false;

        }

        public bool EqualsPassword(string password)
        {
            if (this.Password.Equals(password))
                return true;
            else
                return false;

        }

        public bool UserAlreadyLogin(string login, string password)
        {
            if (this.Password.Equals(password) && this.Login.Equals(login))
                return true;
            else 
                return false;

        }

        public ICollection<string> getRentalsInfo(ICollection<string> listaId)
        {
            List<string> RentalsInfo = new List<string>();

            foreach (Rental rental in Rentals)
            {
                if (listaId.Contains(rental.getIdinString()))
                {
                    RentalsInfo.Add(rental.getInfo());
                }
            }

            return RentalsInfo;
        }



    }


}
