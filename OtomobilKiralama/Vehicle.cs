using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtomobilKiralama
{
    public class Vehicle
    {
        public Vehicle(string brand, string model, int year, decimal dailyRentalFee, string gear, string fuelType)
        {
            Brand = brand;
            Model = model;
            Year = year;
            DailyRentalFee = dailyRentalFee;
            Gear = gear;
            FuelType = fuelType;
        }
        public Vehicle() 
        {
            Brand = "Brand";
            Model = "model";
            Year = 0;
            DailyRentalFee = 0;
            Gear = "Manuel";
            FuelType = "FuelType";
        
        
        }

        public string Brand { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public decimal DailyRentalFee { get; set; }
        public string Gear { get; set; }
        public string FuelType { get; set; }

        

        public virtual void VehicleDetails()
        {
            Console.WriteLine($"Brand : {Brand}, Model : {Model}, Year : {Year}, Gear : {Gear}," +
                $" Fuel Type : {FuelType}   ");
        }

        public virtual decimal CalculateRentalFee()
        {
            return DailyRentalFee;
        }

        public virtual void ReserveVehicle(DateTime startDate)
        {
            // Rezervasyon işlemleri burada gerçekleştirilir
            Console.WriteLine($"Vehicle reserved from {startDate.ToShortDateString()}");
        }
        public virtual void CancelReservation()
        {
            Console.WriteLine("Reservation canceled!");
        }

        







    }
}
