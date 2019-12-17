using System;

namespace Deliverable_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What type of Vacation would you prefer, musical, tropical, or adventurous?");
            string vacationType = Console.ReadLine();
            string destination = null;

            Console.WriteLine("How many people are in your group?");
            int groupSize = int.Parse(Console.ReadLine());
            string travel = null;
           
            if (vacationType == "musical")
            {
                destination = "New Orleans";
            }
            else if (vacationType == "tropical")
            {
                destination = "a beach vacation in Mexico";
            }
            else if (vacationType == "adventurous")
            {
                destination = "go whitewater rafting at the Grand Canyon";
            }

            if (groupSize <= 2)
            {
                travel = "first class flight";
            }
            else if (groupSize <= 5)
            {
                travel = "helicopter";
            }
            else if (groupSize >= 6)
            {
                travel = "charter flight";
            }
            string result = "Since you’re a group of " + groupSize + " going on a " + vacationType + " vacation, you should take a " + travel + " to " + destination + "!";
            Console.WriteLine(result);
            

        } 
        }
    }
