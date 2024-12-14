
namespace ConsoleApp1
{
    public class UserManager
    {
        private List<User> users = new List<User>();

        public void RegisterUser()
        {
            var user = new User();
            
            Console.WriteLine("Enter Full Name: ");
            user.Name = Console.ReadLine();

            Console.WriteLine("Enter Email: ");
            user.Email = Console.ReadLine();

            Console.WriteLine("Enter Password: ");
            user.Password = Console.ReadLine();

            Console.WriteLine("Enter Contact (Phone Number): ");
            user.Contact = Console.ReadLine();

            Console.WriteLine("Enter Address: ");
            user.Address = Console.ReadLine();

            users.Add(user);

            Console.WriteLine("Registration Successful!\n");
            user.PrintUserDetails();
        }

        public void LoginUser()
        {
            Console.WriteLine("Enter Email: ");
            string email = Console.ReadLine();

            Console.WriteLine("Enter Password: ");
            string password = Console.ReadLine();

            var user = users.Find(u => u.Email == email && u.Password == password);

            if (user != null)
            {
                Console.WriteLine("Login Successful!");
                user.PrintUserDetails();
            }
            else
            {
                Console.WriteLine("Invalid Email or Password. Please try again.");
            }
        }
    }
}