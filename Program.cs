using System.ComponentModel;

namespace Hurricane
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int userSelection;
            Console.WriteLine("This Program Tells you the speed of a hurricane by category");
            Console.WriteLine("Please enter a hurricane category (options are 1-5):");
            while (!int.TryParse(Console.ReadLine(), out userSelection))
            {
                Console.Write("This is not valid input. Please enter a Category number: ");
            }

            switch (userSelection)
            {
                case 1:
                    Console.WriteLine("Wind Speeds for a Category 1 are: 119-153 km / 74-95 mph / 64-82 kt");
                    break;
                case 2:
                    Console.WriteLine("Wind Speeds for a Category 2 are: 154-177 km / 96-110 mph / 83-95 kt");
                    break;
                case 3:
                    Console.WriteLine("Wind Speeds for a Category 3 are: 178-210 km / 111-130 mph / 96-113 kt");
                    break;
                case 4:
                    Console.WriteLine("Wind Speeds for a Category 4 are: 210-249 km / 131-154 mph / 114-134 kt");
                    break;
                case 5:
                    Console.WriteLine("Wind Speeds for a Category 5 are: 249+ km / 155+ mph / 135+ kt");
                    break;
            }

        }
        }
    }