using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FortuneTeller
{
    class Program
    {
        static void Main(string[] args)
        {
            //Develop a console application that will tell the user’s fortune 
            //based on data received from the user.

            //Variables and Basic Types
            //Operators and Expressions
            //Conditionals
            //Strings

            //PART 1
            Console.WriteLine("Welcome I'm Sonja your favorite Fortune Teller!");

            //Ask the user for the user’s first name
            string firstName;
            Console.WriteLine("Please enter your first name");
            firstName = Console.ReadLine();

            //Ask the user for the user’s last name
            string lastName;
            Console.WriteLine("Please enter your last name");
            lastName = Console.ReadLine();

            //Ask the user for the user’s age
            int userAge;
            Console.WriteLine("Please enter your age");
            userAge = int.Parse(Console.ReadLine());

            //Ask the user for the user’s birth month(as an 'int')
            int birthMonth;
            Console.WriteLine("Please enter your birth month using a number");
            birthMonth = int.Parse(Console.ReadLine());

            //Ask the user for the user’s favorite ROYGBIV color (SWITCH CASE)
            //Console.WriteLine("What is your favorite ROYGBIV color? Enter 'Help' for a list of ROYGBIV colors");
            //string color = Console.ReadLine();
            //string response = "";
            //switch (color)
            //    {
            //        case "help":
            //            response = "Please choose from the following colors:\n red\n orange\n yellow\n green\n blue\n indigo\n violet\n";
            //            break;
            //        case "red":
            //            response = "red";
            //            break;
            //        case "orange":
            //            response = "orange";
            //            break;
            //        case "yellow":
            //            response = "yellow";
            //            break;
            //        case "green":
            //            response = "green";
            //            break;
            //        case "blue":
            //            response = "blue";
            //            break;
            //        case "indigo":
            //            response = "indigo";
            //            break;
            //        case "violet":
            //            response = "violet";
            //            break;
            //        default:
            //            response = "You fail at colors. Try again.";
            //            break;
            //    }
            //       Console.WriteLine(response);

            //Ask the user for the user’s favorite ROYGBIV color (if statement)
            Console.WriteLine("What is your favorite ROYGBIV color? Enter 'Help' for a list of ROYGBIV colors");
            string color = Console.ReadLine();

            if(color == "Help".ToUpper() || color == "Help".ToLower())
            {
                Console.WriteLine("\n Red\n Orange\n Yellow\n Green\n Blue\n Indigo\n Violet\n");
            }
            if (color == "Red".ToUpper() || color == "Red".ToLower())
            {
                Console.WriteLine("Red");
            }
            if (color == "Orange".ToUpper() || color == "Orange".ToLower())
            {
                Console.WriteLine("Orange");
            }
            if (color == "Yellow".ToUpper() || color == "Yellow".ToLower())
            {
                Console.WriteLine("Yellow");
            }
            if (color == "Green".ToUpper() || color == "Green".ToLower())
            {
                Console.WriteLine("Green");
            }
            if (color == "Blue".ToUpper() || color == "Blue".ToLower())
            {
                Console.WriteLine("Blue");
            }
            if (color == "Indigo".ToUpper() || color == "Indigo".ToLower())
            {
                Console.WriteLine("Indigo");
            }
            if (color == "Violet".ToUpper() || color == "Violet".ToLower())
            {
                Console.WriteLine("Violet");
            }
            Console.ReadLine();


            //Ask the user for the number of siblings the user has
            //string numberOfSiblings;
            //Console.WriteLine("How many siblings do you have?");
            //numberOfSiblings = Console.ReadLine();

            //PART 2


        }
    }
}