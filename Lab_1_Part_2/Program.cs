using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_1_Part_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello User! What are you in the mood for?!"); // Asking the user what type of activity they are in the mood for
            Console.WriteLine("Here are your options! \n1. Action \n2. Chill Times \n3. Danger \n4. Good Food"); // The users options 
            string userTask = Console.ReadLine(); //Taking in the user input
            Console.WriteLine("How many people are you brining with you?");
            string people = Console.ReadLine();

            while (userTask == "1") // While loop if the user enters 1
            {
                if (people == "0") // Condintional statment if the user enters "0", then the following message will print
                {
                    Console.WriteLine("You should be put on your best pair of sneakers and head to the race track for some stock car racing!");
                    break;
                }
                else if (people == "1" || people == "2" || people == "3" || people == "4")
                {
                    Console.WriteLine("You all should hop in a sedan and head to the race track for some stock car racing!");
                    break;
                }
                else if (people == "5" || people == "6" || people == "7" || people == "8" || people == "9" || people == "10")
                {
                    Console.WriteLine("You all should hop in a Volkswagen bus and head to the race track for some stock car racing!");
                    break;
                }
                else
                {
                    Console.WriteLine("I think you're going to need an airplane to fit all of those people for your trip to the race track for some stock car racing!");
                    break;
                }
            }
            while (userTask == "2")
            {
                if (people == "0")
                {
                    Console.WriteLine("You should put on your best pair a sneakers for a nice hike!");
                    break;
                }
                else if (people == "1" || people == "2" || people == "3" || people == "4")
                {
                    Console.WriteLine("You all should hop in a sedan to head out for a nice hike!");
                    break;
                }
                else if (people == "5" || people == "6" || people == "7" || people == "8" || people == "9" || people == "10")
                {
                    Console.WriteLine("You all should hop in a Volkswagen bus to head out for a nice hike!");
                    break;
                }
                else
                {
                    Console.WriteLine("I think you're going to need an airplane to fit all those people when you head out for that hike!");
                    break;
                }
            }
            while (userTask == "3")
            {
                if (people == "0")
                {
                    Console.WriteLine("Put on your best pair of sneakers and head to the airfield for some sky diving!");
                    break;
                }
                else if (people == "1" || people == "2" || people == "3" || people == "4")
                {
                    Console.WriteLine("You all should hop in a sedan to head to the airfield for some sky diving!");
                    break;
                }
                else if (people == "5" || people == "6" || people == "7" || people == "8" || people == "9" || people == "10")
                {
                    Console.WriteLine("You all should hop in Volkswagen bus to head to the airfield for some sky diving!");
                    break;
                }
                else
                {
                    Console.WriteLine("You're going to need an airplane anyway for this sky diving adventure, so you might as well take one!");
                    break;
                }
            }
            while (userTask == "4")
            {
                if (people == "0")
                {
                    Console.WriteLine("Grab your sneakers and walk over to Taco Bell!");
                    break;
                }
                else if (people == "1" || people == "2" || people == "3" || people == "4")
                {
                    Console.WriteLine("You all should hop in a sedan and head over to Taco Bell! ");
                    break;
                }
                else if (people == "5" || people == "6" || people == "7" || people == "8" || people == "9" || people == "10")
                {
                    Console.WriteLine("You all should hop in a Volkswagen bus and head over to Taco Bell!");
                    break;
                }
                else
                {
                    Console.WriteLine("I think you're going to need an airplane to fit all those people, so you can travel the world to find the best Taco Bell!");
                    break;
                }
            }

            Console.WriteLine("Goodbye!"); // Writline that is saying "goodbye" to the user
            Console.ReadLine();



        }
    }
}
