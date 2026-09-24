namespace BankSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Välkommen till Project Bank");

            while (true)
            {
                bool loggedIn = false;
                
                Console.Clear();
                Console.Write("Skriv ditt användarnamn: ");
                string userInput = Console.ReadLine();

                int incorrectPasswordCount = 0;

                

                if(userInput == userName)
                {
                    Console.WriteLine("Rätt användarnamn");
                    Console.Write("Knappa in ditt lösenord:");
                    string passwordInput = Console.ReadLine();

                    bool correctUserName = true;

                    if (passwordInput == password)
                    {
                        bool loggedIn = true;
                        Console.WriteLine("Rätt lösenord och användarnamn. Du är nu inloggad");
                        Console.ReadKey();
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Fel lösenord, försök igen.");
                    }


                }
                else
                {
                    Console.WriteLine("Felaktigt användarnamn. Försök igen");
                }
                break;
            }

            while (loggedIn)
            {
                Console.WriteLine("Meny");
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine();
            }
            
            
        }
    }
    class User
    {
        public string userName { get; set; }
        public string password { get; set; }

        public
    }
    class Account
    {
        public string accountNumber; { get; set; }
        public decimal accountBalance; { get; set; }
        public string accountType; { get; set; }

    }
}



