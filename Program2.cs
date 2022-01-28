using System;

namespace Deliverable1
{
    internal class Program
    {

        static void Main(string[] args)

        {

            var done = false;

            while (!done) {
                Console.WriteLine("How many people are we making PB&J sandwiches for?");
                int a = Convert.ToInt32(Console.ReadLine());


                var tbsp = 2;

                var tspn = 4;

                var slices = 2;

                var loafs = 28;

                var pbJar = 32;

                var jJar = 48;

                Console.WriteLine("You need:");

                Console.WriteLine((a * tbsp) + " Tablespoons of Peanut Butter.");

                Console.WriteLine((a * tspn) + " Teaspoons of Jelly.");

                Console.WriteLine((a * slices) + " Slices of Bread.");




                Console.WriteLine("Which is:");

                Console.WriteLine((a / loafs) + " Loafs of Bread.");

                Console.WriteLine((a / pbJar) + " Jars of Peanut Butter.");

                Console.WriteLine((a / jJar) + " Jars of Jelly.");



                Console.WriteLine("Would you Like to restart? Enter yes or y to continue, or enter any other key to exit.");
                
                var response = Console.ReadLine();
               
                if (response != "yes" || response != "y")
                { 
                    done = true; 
                    Console.WriteLine("Good Bye!");
                
                }
                else
                {
                    done=false;
                }
                }
              




                


            
        }
    } }