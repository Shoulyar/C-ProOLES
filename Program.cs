namespace C_Pro
{
    internal class Program
    {
        static void Main(string[] args)
        {
            User user1 = new User();
            user1.Gender = Gender.Female;

            Console.WriteLine("Please, enter First Name:");
            user1.FirstName = Console.ReadLine();
            Console.WriteLine("Please, enter Last Name:");
            user1.LastName = Console.ReadLine();
            Console.WriteLine(user1.ToString());

        }
    }
}
