﻿using System;
using EcoScooter.Entities;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestEcoScooterPersistence
{
    [TestClass]
    public class RentalTest
    {
        //Rental Data
        private static DateTime? EXPECTED_END_DATE = new Date​Time(2019, 10, 14,16,55,56);
        private static decimal EXPECTED_PRICE = 23;
        private static DateTime EXPECTED_START_DATE = new Date​Time(2019, 10, 14,16,15,0);
        // Station Data
        private const string EXPECTED_ADDRESS = "somewhere street";
        private const string EXPECTED_STATION_ID = "cityCenter";
        private const double EXPECTED_LAT = 10;
        private const double EXPECTED_LONG = 34;
       
        //User Data 
        private static DateTime EXPECTED_BIRTHDATE = new Date​Time(2000, 07, 27);
        private const string EXPECTED_DNI = "14422178M";
        private const string EXPECTED_EMAIL = "somebody@outlook.es";
        private const string EXPECTED_NAME = "Somebody White";
        private const int EXPECTED_TELEPHON = 6006787;
        private const int EXPECTED_CVV = 324;
        private static DateTime EXPECTED_EXPIRATION_DATE = new Date​Time(2022, 12, 31);
        private const string EXPECTED_LOGIN = "somebody";
        private const int EXPECTED_NUMBER = 1234567891;
        private const string EXPECTED_PASSWORD = "password";
      
        //Scooter Data

        private static DateTime EXPECTED_REGISTER_DATE = new Date​Time(2019, 10, 14);
        private const ScooterState EXPECTED_STATE = ScooterState.inMaintenance;
        

        [TestMethod]
        public void NoParamsConstructorInitializesTrackpoints()
        {
            Rental rental = new Rental();
            Assert.IsNotNull(rental.TrackPoints, "Collection of TrackPoint no properly initialized. \n Patch the problem adding: TrackPoints = new List<TrackPoint>();");

        }
        [TestMethod]
        public void ParamsConstructorIntilizesProps()
        { 
            Station expectedStation = new Station(EXPECTED_ADDRESS, EXPECTED_STATION_ID, EXPECTED_LAT, EXPECTED_LONG);
            User expectedUser = new User(EXPECTED_BIRTHDATE, EXPECTED_DNI, EXPECTED_EMAIL, EXPECTED_NAME, EXPECTED_TELEPHON,
                                            EXPECTED_CVV, EXPECTED_EXPIRATION_DATE, EXPECTED_LOGIN, EXPECTED_NUMBER, EXPECTED_PASSWORD);
            Scooter expectedScooter = new Scooter(EXPECTED_REGISTER_DATE, EXPECTED_STATE);
        Rental rental = new Rental(EXPECTED_END_DATE,  EXPECTED_PRICE, EXPECTED_START_DATE, expectedStation, expectedScooter, expectedUser);
            Assert.AreEqual(EXPECTED_END_DATE, rental.EndDate, "EndDate not properly initialized. Check params order and assigment");
            Assert.AreEqual(EXPECTED_PRICE, rental.Price, "Price not properly initialized. Check params order and assigment");
            Assert.AreEqual(EXPECTED_START_DATE, rental.StartDate, "StartDate not properly initialized. Check params order and assigment");

            Assert.IsNotNull(rental.TrackPoints, "Collection of TrackPoint no properly initialized. \n Patch the problem adding: TrackPoints = new List<TrackPoint>();");
            Assert.IsNotNull(rental.OriginStation, "OriginStation not properly initialized.Check assigment");
            Assert.AreEqual(EXPECTED_STATION_ID, rental.OriginStation.Id, "OriginStation not properly initialized.Check assigment");
            Assert.IsNotNull(rental.Scooter, "Scooter not properly initialized.Check assigment");
            Assert.IsNotNull(rental.User, "User not properly initialized.Check assigment");
            Assert.AreEqual(EXPECTED_DNI,rental.User.Dni, "User not properly initialized.Check assigment");

        }
    }
}
