
namespace ConsoleApp1
{
    public class Menu
    {
        private UserManager userManager = new UserManager();
        private ProviderRegistration providerRegistration = new ProviderRegistration();
        private RiderRegistration riderRegistration = new RiderRegistration();

        public void DisplayMenu()
        {
            while (true)
            {
                Console.WriteLine("\n1. User Registration");
                Console.WriteLine("2. User Login");
                Console.WriteLine("3. Provider Enlistment");
                Console.WriteLine("4. Rider Enlistment");
                Console.WriteLine("5. Exit");
                Console.Write("Enter your choice: ");

                string input = Console.ReadLine();
                if (int.TryParse(input, out int choice))
                {
                    switch (choice)
                    {
                        case 1:
                            userManager.RegisterUser();
                            break;
                        case 2:
                            userManager.LoginUser();
                            break;
                        case 3:
                            providerRegistration.Enlister();
                            break;
                        case 4:
                            riderRegistration.Rider();
                            break;
                        case 5:
                            Console.WriteLine("Exiting the program. Goodbye!");
                            return;
                        default:
                            Console.WriteLine("Invalid choice. Please try again.");
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a number.");
                }
            }
        }
    }
}