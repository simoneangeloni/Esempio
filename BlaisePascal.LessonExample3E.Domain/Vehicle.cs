using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace BlaisePascal.LessonExample3E.Domain
{
    public class Vehicle
    {
        private int _id;

        private int _odometerKm;
        private double _dailyRate;
        private double _fuelLevelPercentage;

        public string LicensePlate { get; private set; }
        public int OdometerKm { get { return _odometerKm; } private set; }
        public double DailyRate { get; private set; }
        public double FuelLevelPercentage { get; private set; }

        public Vehicle(string licensePlate) {
        LicensePlate = licensePlate;
        }

        public Vehicle(string licensePlate, int odometerKm, double dailyRate, double fuelLvelPercentage) { 
        LicensePlate= licensePlate;
        OdometerKm = odometerKm;
        DailyRate = dailyRate;
        FuelLevelPercentage = fuelLvelPercentage;

        }

    }
}
   
