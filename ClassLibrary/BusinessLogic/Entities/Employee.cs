using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//business logic 
namespace EcoScooter.Entities
{
    public partial class Employee:Person
    {
        public Employee()
        {

            this.Maintenances = new List<Maintenance>();
        }
        public Employee (DateTime Birthdate, String Dni, String Email, String Name, int Telephon, String Iban,
                    int Pin, String Position, Decimal Salary) : base(Birthdate, Dni, Email, Name, Telephon) //como coloco el this si ya tiene el base
        {
            this.Iban = Iban;
            this.Pin = Pin;
            this.Position = Position;
            this.Salary = Salary;
            this.Maintenances = new List<Maintenance>();
        }


        public bool EqualsPin(int pin)
        {
            if (this.Pin.Equals(pin))
                return true;
            else
                return false;
        }

        public bool EmployeeAlreadyLogin(string dni, int pin)
        {
            if (this.Dni.Equals(dni) && this.Pin.Equals(pin))
                return true;
            else
                return false;

        }

        public static bool EmptyDni(string dni)
        {
            if (dni == null)
            {
                return true;
            }
            return false;
        }

        public static bool EmptyPin(int pin)
        {

            if (pin == 0)
            {
                return true;
            }
            return false;
        }

    }
}
