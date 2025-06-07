namespace CoreLibraryManager
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool isAppRunning = true;

            while (isAppRunning)
            {
                Console.WriteLine("1. Add a new book");
                Console.WriteLine("2. Exit");

                string? menuOption = Console.ReadLine();

                switch (menuOption)
                {
                    case "1":
                        break;

                    case "2":
                        Console.Clear();
                        Console.WriteLine("See you soon!");
                        isAppRunning = false;
                        break;
                }
            }
        }
    }
}
