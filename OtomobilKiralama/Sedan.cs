using Microsoft.VisualBasic.FileIO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace OtomobilKiralama
{
    internal class Sedan : Vehicle
    {
        public int BaggageCapacity { get; set; }

        public Sedan(int baggageCapacity, string brand, string model, int year, decimal dailyRentalFee, string gear, string fuelType)
        {
            Brand = brand;
            Model = model;
            Year = year;
            DailyRentalFee = dailyRentalFee;
            Gear = gear;
            FuelType = fuelType;
            BaggageCapacity = baggageCapacity;
        }
        public override void VehicleDetails()
        {
            base.VehicleDetails();
            Console.WriteLine($"Baggage Capacity : {BaggageCapacity}");
        }


    }
}
