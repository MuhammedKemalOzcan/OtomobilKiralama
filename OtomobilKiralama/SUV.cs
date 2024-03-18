using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtomobilKiralama
{
    internal class SUV : Vehicle
    {
        public SUV(bool fourWheelDrive, int baggageCapacity, string brand, string model, int year, decimal dailyRentalFee, string gear, string fuelType)
        {
            Brand = brand;
            Model = model;
            Year = year;
            DailyRentalFee = dailyRentalFee;
            Gear = gear;
            FourWheelDrive = fourWheelDrive;
            BaggageCapacity = baggageCapacity;
            FuelType = fuelType;
        }

        public bool FourWheelDrive { get; set; }
        public int BaggageCapacity { get; set; }


        public override void VehicleDetails()
        {
            base.VehicleDetails();
            Console.WriteLine($"4x4 : {FourWheelDrive}, Baggage Capacity {BaggageCapacity}");
        }




    }
}
