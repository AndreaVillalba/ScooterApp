using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EcoScooter.Entities;
using EcoScooter.Persistence;

namespace EcoScooter.Services
{
    public class EcoScooterService : IEcoScooterService
    {
        private readonly IDAL dal; //DAL: access to persistence layer
        private Entities.EcoScooter ecoScooter; //Represents current system data
        private User loggedUser;
        private Employee loggedEmployee;


        /// Updates fare, discount and maxspeed of the system 

        public void UpdateEcoScooterData(double discountYounger, double fare, double maxSpeed)
        {
            ecoScooter.DiscountYounger = discountYounger;
            ecoScooter.Fare = fare;
            ecoScooter.MaxSpeed = maxSpeed;

        }

        /// Initializes the service Layer

        public EcoScooterService(IDAL dal)
        {
            this.dal = dal;
            //Gets the initial EcoScooter or creates a new one
            try
            {   //We assume we only have one EcoScooter
                ecoScooter = this.dal.GetAll<Entities.EcoScooter>().First();
            }
            catch (InvalidOperationException)
            {
                ecoScooter = new Entities.EcoScooter(); //Relaxing the model, because there is no employee and data
                UpdateEcoScooterData(10, 15, 30); //15 and not 0.015 for simultion purpouses. 
                dal.Insert(ecoScooter);
                dal.Commit();
            }

        }
        public void GetRouteDescription(int rentalId, out DateTime startDate, out DateTime endDate, out decimal price, out string originStationId, out string destinationStationId)
        {
            Rental rental;
            rental = dal.GetById<Rental>(rentalId);
            
            if (loggedUser == null)  //he sustituido loggedEmployee por loggedUser, veia que cuadraba mas
                throw new ServiceException("Para consultar rutas debe haber iniciado sesion");
            else if (rental==null)
                throw new ServiceException("No existe ninguna estacion con ese Id");
            else
            {
                startDate = rental.getStartDate();
                endDate = rental.getEndDate().Value;
                price = rental.getPrice();
                originStationId = rental.getOriginStation();
                destinationStationId = rental.getDestinationStation();
            }

     
        }

        public ICollection<string> GetUserRoutes(DateTime startDate, DateTime endDate)
        {
            if (loggedUser == null)
                throw new ServiceException("Para consultar rutas debe haber iniciado sesion");
            else
            {
                ICollection<string> ListaIds=  GetUserRoutesIds(startDate, endDate);
                return loggedUser.getRentalsInfo(ListaIds);
      
            }
          
         
        }

        public ICollection<string> GetUserRoutesIds(DateTime startDate, DateTime endDate)
        {
            if(loggedUser==null)
                throw new ServiceException("Para consultar rutas debe haber iniciado sesion");
            else
            {
                if (!Rental.ValidIntervalDates(startDate, endDate))
                    throw new ServiceException("Debe introducir un intervalo valido de fechas");
                else if (loggedUser.GetRentalsId(startDate, endDate).Count() == 0)
                    throw new ServiceException("No hay rutas disponibles en este intervalo de fechas");
                else
                {
                    return loggedUser.GetRentalsId(startDate, endDate);
                }
            }
          
           
        }

        public bool isLoggedAsEmployee(string dni)
        {
            try
            {
                return loggedUser.EqualsDni(dni);
            }
            catch (Exception) //There is not loggedUSer
            {
                return false;

            }
        }
        /// <summary>
        /// Checks if the dni correponds to current logged user
        /// </summary>
        /// <param name="dni"></param>
        /// <returns>Returns true if the user is the current logged user, false otherwise</returns>
        public bool isLoggedAsUser(string dni)
        {
            try
            {
                return loggedUser.EqualsDni(dni);
            }
            catch (Exception) //There is not loggedUSer
            {
                return false;

            }
        }

        public void LoginEmployee(string dni, int pin)
        {
            Employee employee = ecoScooter.PinMatch(dni, pin);
            if (loggedEmployee != null)
                throw new ServiceException("No puedes iniciar sesion, ya hay un empleado dentro");
            
            else if (employee== null)
                throw new ServiceException("Dni o pin incorrectos");

            else
            { 
                loggedEmployee = employee;
            }


        }

        public void LogOut()
        {
            if (loggedUser != null)
                loggedUser = null;
            if (loggedEmployee != null)
                loggedEmployee = null;
        }

        public void LoginUser(string login, string password)
        {
            User user = ecoScooter.PasswordMatch(login, password);
            if (loggedUser!=null)
                throw new ServiceException("No puedes iniciar sesion, ya hay un usuario dentro");
 
            else if (user == null)
                throw new ServiceException("Login o contraseña incorrecta");
           
            else
            {
                loggedUser = user;
            }


        }

        public void RegisterIncident(string description, DateTime timeStamp, int rentalId)
        {
            if (loggedUser == null)
                throw new ServiceException("Debe haber iniciado sesion como usuario para registrar un incidente");
            else
            {
                ecoScooter.SetIncident(description, timeStamp, rentalId, loggedUser);
                saveChanges();
            }
        }

        public void RegisterScooter(DateTime registerDate, ScooterState state, string stationId)
        {
            Station station = ecoScooter.GetStation(stationId);
            if (loggedEmployee == null)
                throw new ServiceException("Debe haber iniciado sesion como empleado para regisstrar un scooter");
           
            else if (!Scooter.ValidRegisterDate(registerDate)) //futuro error
                throw new ServiceException("Debe introducir una fecha valida");

            else if (state== ScooterState.available && ecoScooter.GetStation(stationId) == null)
                throw new ServiceException("Debes introducir un id valido para colocar el scooter");
            else
            {
                ecoScooter.AddScooter(registerDate, state, station);
                saveChanges();
            }
            
         

        }

        public void RegisterStation(string address, double latitude, double longitude, string stationId)
        {

            if (loggedEmployee == null)
                throw new ServiceException("No has iniciado sesión como empelado");
            else if (ecoScooter.GetStation(stationId)!=null)
                throw new ServiceException("Ya hay una estación registrada con ese ID");
            else if (!Station.ValidAddress(address))
                throw new ServiceException("Introduzca una dirección valida.Recuerde que no puede estar vacia");
            else if (!Station.GPSLat(latitude))
                throw new ServiceException("Las coordenadas GPS que hacen referencia a la latitud no son validas");
            else if (!Station.GPSLon(longitude))
                throw new ServiceException("Las coordenadas GPS que hacen referencia a la longitud no son validas");
           
            else
            {
                ecoScooter.AddStation(address, latitude, longitude, stationId);
                saveChanges();
            }
        }

        public void RegisterUser(DateTime birthDate, string dni, string email, string name, int telephon, int cvv, DateTime expirationDate, string login, int number, string password)
        {
           
            if (ecoScooter.ExistsPerson(dni))
                throw new ServiceException("Este usuario ya esta registrado");
            else if (ecoScooter.ExistsLogin(login))
                throw new ServiceException("Ya existe este nombre de usuario");
            else if (!Person.OlderThan16(birthDate))
                throw new ServiceException("Debe tener al menos 16 años para poder registrarte");
            else if (!Person.ValidEmail(email))
                throw new ServiceException("Por favor introduzca un correo valido");
            else if (!User.ValidCardNumber(number))
                throw new ServiceException("Numero de tarjeta invalido: debe tener 8 digitos");
            else if (!User.ValidCVV(cvv))
                throw new ServiceException("CVV invalido: debe tener 3 digitos");
            else if (!User.ValidExpirationDate(expirationDate))
                throw new ServiceException("Tarjeta expirada");
            else
            {
                ecoScooter.AddUser(birthDate, dni, email, name, telephon, cvv, expirationDate, login, number, password);
                saveChanges();
            }

        }

        public void removeAllData()
        {
            dal.RemoveAllData();
        }

        public void RentScooter(string stationId)
        {
           
            Station actualStation = ecoScooter.GetStation(stationId);
           

            //Scooter scooterAlquilado;
            //Station actualStation;

            // ecoScooter.getScooterandStation(stationId, out actualStation, out scooterAlquilado);

            if (loggedUser == null)
                throw new ServiceException("No puede rentar un scooter si no ha iniciado sesion");
            else if (stationId.Length==0)
                throw new ServiceException("Debes elegir una estacion");
            else if (actualStation == null)
                throw new ServiceException("No existe la estacion");
            else if (loggedUser.GetActualRental()!= null)
            {
                if (loggedUser.GetActualRental().getEndDate().HasValue==false)
                throw new ServiceException("No puedes alquilar un scooter hasta que devuelvas el ultimo");

            }
               
            else
            {
                Scooter scooterAlquilado = actualStation.GetFirstScooter();

                if (scooterAlquilado == null)
                    throw new ServiceException("No hay ningun scooter disponible en esta estacion");
                else
                {
                    loggedUser.AddRental(actualStation, scooterAlquilado, loggedUser);
                    saveChanges(); 
                }
            }
            
      
        }

        public bool UserHaveScooter()
        {
            Rental rental = loggedUser.GetActualRental();
            return (rental != null);
        
        }

        public ICollection<string> GetStations()
        {
           return ecoScooter.getALLStations();
        }

        public string GetLastRental()
        {
            return loggedUser.GetLastRentalId();
        }
        public void ReturnScooter(string stationId)
        {
            Station destinationStation = ecoScooter.GetStation(stationId);

            if (loggedUser==null)
                throw new ServiceException("Para devolver el scooter debe haber iniciado sesion");
            else if (destinationStation == null)
                throw new ServiceException("No existe ninguna estacion asociada con el id");
            else
            {
                Rental myrental = loggedUser.GetActualRental();
                if (myrental == null)
                    throw new ServiceException("No tienes ningun scooter pendiente de devolver");
                else
                {
                    myrental.UpdateRental(destinationStation, loggedUser, myrental, ecoScooter);
                    saveChanges();
                }
            }
         
        }

        public void saveChanges()
        {
            dal.Commit();

        }



  


       public void RegisterEmployee(DateTime birthDate,string dni, string email, string name, int telephon, string iban , int pin, string position, decimal salary)
        {
            ecoScooter.AddEmployee(birthDate,  dni,  email,  name,  telephon,  iban,  pin,  position,  salary);
            saveChanges();

        }
    }
}