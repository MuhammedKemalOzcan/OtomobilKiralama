namespace OtomobilKiralama
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Sedan sedan = new Sedan(10,"Toyota","Corolla",2017,70,"Manuel","Gasoline");
            sedan.VehicleDetails();
            Console.WriteLine($"Rental Fee : {sedan.CalculateRentalFee()}");
            sedan.ReserveVehicle(DateTime.Now);

            SUV suv = new SUV(true,15,"Chevrolet","Captiva",2024,90,"Automatic","Diesel");
            suv.VehicleDetails();
            Console.WriteLine($"Rental Fee : {suv.CalculateRentalFee()}");


        }
    }
}
