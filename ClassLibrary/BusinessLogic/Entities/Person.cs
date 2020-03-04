using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EcoScooter.Services;
//persistence
namespace EcoScooter.Entities
{
    public partial class Person
    {
        public Person()
        {

        }

        public Person(DateTime Birthdate, String Dni, String Email, String Name, int Telephon)
        {
            this.Birthdate = Birthdate;
            this.Dni = Dni;
            this.Email = Email;
            this.Name = Name;
            this.Telephon = Telephon;


        }

        public static bool OlderThan16(DateTime birthDate)
        {
          
            int age = DateTime.Now.Year - birthDate.Year;

            if (DateTime.Now.Month<birthDate.Month|| DateTime.Now.Month == birthDate.Month && DateTime.Now.Day < birthDate.Day)
                age--;

            if (age >= 16)
                return true;
            else
                return false;
               
        }

        public bool EqualsDni(string dni)
        {
            if (dni == this.Dni)
            {
                return true;
            }
            return false;
        }

        public static bool ValidEmail(string email)
        {

            return email.Contains("@") && email.Contains(".");


        }




    }


    
}
