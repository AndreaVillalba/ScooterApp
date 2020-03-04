using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcoScooter.Entities
{
    public partial class EcoScooter
    {
        public EcoScooter()
        {
            this.People = new List<Person>();
            this.Scooters = new List<Scooter>();
            this.Stations = new List<Station>();
            this.Employees = new List<Employee>();

        }
        public EcoScooter(Double DiscountYounger, Double Fare, Double MaxSpeed, Employee Employee) : this()
        {
            //si es de 1 a 1..* pero va en una sola direccion, no hay que relajar?
            this.DiscountYounger = DiscountYounger;
            this.Fare = Fare;
            this.MaxSpeed = MaxSpeed;
            this.Employees.Add(Employee);
            this.People.Add(Employee);

        }

        public void AddEmployee(DateTime birthDate, string dni, string email, string name, int telephon, String Iban, int Pin, String Position, Decimal Salary)
        {
            Employee employee = new Employee(birthDate, dni, email, name, telephon, Iban, Pin, Position, Salary);
            People.Add(employee);
            Employees.Add(employee);
        }


        public void AddUser(DateTime birthDate, string dni, string email, string name, int telephon, int cvv, DateTime expirationDate, string login, int number, string password)
        {
            User user = new User(birthDate, dni, email, name, telephon, cvv, expirationDate, login, number, password);
            People.Add(user);
        }

        public ICollection<string> getALLStations()
        {
            ICollection<string> stationID= new List<string>();
            foreach (Station station in Stations)
            {
                stationID.Add(station.getId());
            }
            return stationID;
        }

        public void AddScooter(DateTime registerDate, ScooterState state, Station station)
        {

            Scooter scooter = new Scooter(registerDate, state);
            Scooters.Add(scooter);
            if (scooter.IsStateAvailable(state))
            {
                station.AddScooter(scooter);
                scooter.SetStation(station);

            }
        }

        public void AddStation(string address, double latitude, double longitude, string stationId)
        {
            Station station = new Station(address, stationId, latitude, longitude);
            Stations.Add(station);
        }

        public bool ExistsPerson(string dni)
        {
            foreach (Person person in People)
            {
                if (person.EqualsDni(dni))
                    return true;
            }

            return false;

        }

        public bool ExistsLogin(string login)
        {

            foreach (Person person in People)
            {
                if (person is User)
                {
                    User user = (User)person;
                    if (user.EqualsUserName(login))
                        return true;

                }

            }

            return false;

        }

        //public bool IsScooterAvailable(string id_station)
        //{

        //    foreach (Station station in Stations)
        //    {
        //        if (station.EqualsStation(id_station))
        //             return station.IsAvailable();
        //    }
        //    return false;

        //}

        //public void getScooterandStation(string id_station, out Station actualStation, out Scooter actualScooter)
        //{
        //        actualStation = null;
        //        actualScooter = null;
           
        //    foreach (Station station in Stations)
        //    {
        //        if (station.EqualsStation(id_station))
        //        {
        //            actualScooter = station.GetFirstScooter();
        //            actualStation = station;

        //        }
                    
        //    }
        //    //return null;

        //}

        //public void generateRental(Scooter scooterAlquilado, Station station, User loggedUser)
        //{
        //    DateTime? EndDate = null;
        //    Decimal Price = 0.015m;
        //    DateTime StartDate = DateTime.Today;
        //    Station OriginStation = station;


        //    scooterAlquilado.State = ScooterState.inUse;

        //   // loggedUser.AddRental(EndDate, Price, StartDate, OriginStation, scooterAlquilado, loggedUser);

        //    station.DeleteFirstScooter(); //asumo que la lista esta ordenada


        //    //Rentals.Add(scooterAlquilado);

        //}



        public Employee PinMatch(string dni, int pin)
        {

            foreach (Person person in People)
            {
                if (person is Employee)
                {
                    Employee employee= (Employee)person;
                    if (employee.EqualsDni(dni) && employee.EqualsPin(pin))
                        return employee;

                }

            }
            return null;

        }

        public User PasswordMatch(string login, string password)
        {

            foreach (Person person in People)
            {
                if (person is User)
                {
                    User user = (User)person;
                    if (user.EqualsUserName(login) && user.EqualsPassword(password))
                        return user;

                }

            }

            return null;

        }

        public Station GetStation(string stationId)
        {
            foreach (Station station in Stations)
            {
                if (station.EqualsStation(stationId))
                    return station;
            }
            return null;
        }

        public decimal CalculatePrice(DateTime endtime,  DateTime startTime, int age)
        {
            double minutos = endtime.Subtract(startTime).TotalMinutes;

            decimal price = (decimal)(this.Fare * minutos);

            return price;
       
        }
        public decimal CalculateDiscount(decimal price)
        {     

            return price - (price * (decimal)(this.DiscountYounger / 100));
        }
        

        //public void UpdateRental(Station destinationStation, Rental rental, User usuarioLoggeado)
        //{
            

        //    DateTime endDate = DateTime.Now;
          
        //    double minutos= rental.GetTime(endDate);

        //    rental.SetPrice(CalculatePrice(minutos, usuarioLoggeado.getAge()));
        //    rental.SetDestinationStation(destinationStation);
        //    rental.SetEndDate(endDate);
            
        //    rental.ScooterStateAvailable();

        //    destinationStation.AddDestinationRental(rental);
           

        //}

        public void SetIncident(string description, DateTime timeStamp, int rentalId, User loggedUser)
        {
            Rental rental;
            rental = loggedUser.GetRentalbyID(rentalId); // lo puedo dejar asi?

            rental.GenerateIncident(description, timeStamp);
        }





    }
}


//Todo OK