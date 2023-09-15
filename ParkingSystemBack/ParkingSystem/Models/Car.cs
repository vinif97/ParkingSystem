namespace ParkingSystem.Models
{
    public class Car
    {
        public int CarId { get; set; }
        public string LicensePlate { get; set; }
        public ParkingSection? ParkingSection { get; set; }

        public Car(ParkingSection parkingSection, string licensePlate)
        {
            ParkingSection = parkingSection;
            LicensePlate = licensePlate;
        }

        public Car(string licensePlate) 
        { 
            LicensePlate = licensePlate;
        }
    }
}
