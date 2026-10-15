using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Text.RegularExpressions;

namespace BlaisePascal.LessonExample3E.Domain
{
    public class Vehicle
    {
        private int _odometerKm;
        private double _dailyRate;
        private double _fuelLevelPercentage;
        private string _licensePlate;

        public static int MaxFuelLevelPercentage { get; } =100;

        public string LicensePlate { 
            get 
            {
                return _licensePlate;

            } private set
            {

                if (string.IsNullOrWhiteSpace(value) || value.Length != 7)
                    throw new ArgumentException($"value not allowed {nameof(LicensePlate)}: {value} ");
                else
                {
                    string licensePlate = value.Trim().ToUpper();
                    if (Regex.IsMatch(licensePlate, @"[A-Z]{2}[0-9]{3}[A-Z]{2}"))
                    {
                        _licensePlate = licensePlate;
                    }
                    else
                    {
                        throw new ArgumentException($"value not allowed {nameof(LicensePlate)}: {value} ");
                    }

                }
            }
        }
        public int OdometerKm
        {
            get
            { return _odometerKm; }
            private set
            {
                if (value < 0)
                    throw new ArgumentException($"value not allowed {nameof(OdometerKm)}: {value} ");

                _odometerKm = value;
            }
        }
        public double DailyRate { get; private set; }

        public double FuelLevelPercentage
        {
            get
            { return _fuelLevelPercentage; }
            private set
            {
                if (value < 0 || value > 100)
                    throw new ArgumentException($"value not allowed {nameof(FuelLevelPercentage)}: {value} ");

                _fuelLevelPercentage = value;
            }
        }

        


        /// <summary>
        /// metodo costruttore che inizializza la targa del veicolo
        /// </summary>
        /// <param name="licensePlate"></param>
        public Vehicle(string licensePlate) : this(licensePlate, 0, 0, 100) //chiamata al costruttore con 4 parametri
        {
            //chiama al set           
        }

        /// <summary>
        /// metodo costruttore che inizializza la targa del veicolo, il contachilometri, il prezzo giornaliero e il livello di carburante
        /// </summary>
        /// <param name="licensePlate"></param>
        /// <param name="odometerKm"></param>
        /// <param name="dailyRate"></param>
        /// <param name="fuelLevelPercentage"></param>
        public Vehicle(string licensePlate, int odometerKm,
            double dailyRate, double fuelLevelPercentage)
        {
            LicensePlate = licensePlate; //chiamata al set
            OdometerKm = odometerKm; //chiamata al set
            DailyRate = dailyRate;
            FuelLevelPercentage = fuelLevelPercentage;
        }

        public void RegisterData(int consumedKm, double consumedFuel)
        {
            //controlli sui parametri (argument)
            if (consumedKm <= 0)
                throw new ArgumentException($"value not allowed {nameof(consumedKm)}: {consumedKm} ");
            if (consumedFuel < 0)
                throw new ArgumentException($"value not allowed {nameof(consumedFuel)}: {consumedFuel} ");

            //aggiorno lo stato dell'oggetto
            OdometerKm += consumedKm; //chiamata al set
            FuelLevelPercentage -= consumedFuel; //chiamate set
        }

    }
}
   
