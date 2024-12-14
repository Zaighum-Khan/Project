
namespace ConsoleApp1
{
    public class RiderRegistration
    {
        private List<Riders> riders = new List<Riders>(); 

        public void Rider()
        {

            var rider = new Riders();
            Console.WriteLine("Enter Name: ");
            rider.Name = Console.ReadLine();

            Console.WriteLine("Enter Vehicle Type (1 for Bike , 2 for Car): ");
            rider.Vehicle = Console.ReadLine();

            Console.WriteLine("Enter License Number: ");
            rider.License = Console.ReadLine();

            Console.WriteLine("Enter Vehicle Plate Number: ");
            rider.NumPlate = Console.ReadLine();

            Console.WriteLine("Enter Contact (Phone Number): ");
            rider.Contact = Console.ReadLine();

            Console.WriteLine("Enter Address: ");
            rider.Address = Console.ReadLine();
                
            riders.Add(rider);

        }
    }
}