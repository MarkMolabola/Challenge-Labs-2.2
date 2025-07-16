using System.Diagnostics.Metrics;

namespace Challenge_Labs_2._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string realUserName = "admin";
            string realPassword = "password";
            int attempts = 0;
            bool continueProgram = true;

            do
            {
                Console.WriteLine("Enter UserID: ");
                string userId = Console.ReadLine();
                Console.WriteLine("Enter Password: ");
                string password = Console.ReadLine();

                if (userId == realUserName && password == realPassword)
                {
                    Console.WriteLine("Congrats you got it!");
                    continueProgram = false;
                }
                else
                {

                    attempts++;
                    Console.WriteLine("Incorrect UserID. Please try again.");

                    if (attempts == 2)
                    {
                        Console.WriteLine("Max attempts used...exiting Program..");
                        continueProgram = false;

                    }

                }
            } while (continueProgram);
            return;







        }
    }
}
