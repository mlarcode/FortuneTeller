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

            // Ask user first name
            Console.WriteLine("What is your first name?");
            string firstname = Console.ReadLine();

            //Ask user last name
            Console.WriteLine("What is your last name?");
            string lastname = Console.ReadLine();
            Console.WriteLine("Hello" + firstname + lastname);

            //Ask for user age
            int x;
            Console.WriteLine("What is your age?");
            int age = int.Parse(Console.ReadLine());
            if  (x%2==0)
            {
                //This will only appear when the number is even
                Console.WriteLine(" You will retire in 6 years");
            }
            else 
            {
                //This will only appear when the number is odd
                Console.WriteLine("Aww, you have a loooong way to go!");
            }
            Console.ReadLine();

            //Ask for user birth month
            Console.WriteLine("What is your birth month?");
            Console.ReadKey();
            {


            }

            //Ask user for favorite color
            Console.WriteLine("What is your favorite ROYGBIV color?  If you don't know what ROYGBIV is ask for  + "help")
        {
                string[] ROYGBIV = { "Red , Orange , Yellow , Green , Blue , Indigo , Violet"};
                foreach(string item in ROYGBIV)
                {
                    Console.WriteLine(item);
                }
                if (Red)
                {
                    Console.WriteLine(" You will travel by UBER");
                }
                else if (Orange)
                {
                    Console.WriteLine("You will travel by plane.");
                }
                else if (Yellow)
                {
                    Console.WriteLine(" You will travel by bus!");
                }
                else if (Green)
                {
                    Console.WriteLine("You will travel by tractor");
                }
                else if (Blue)
                {
                    Console.WriteLine("You will travel by luxury car.");
                }
                else if (Indigo)
                {
                    Console.WriteLine("You will travel by bike.");
                }
                else (Violet)
                {
                    Console.WriteLine("You will travel by hover board.");
                {
                    Console.ReadKey();
                }
                    }
                }
            }

            // Ask user number of siblings
            Console.WriteLine("How many siblings do you have?");
            int siblings = Convert.ToInt32(Console.ReadLine());

            if (siblings == 0)
            {
                Console.WriteLine(" You will live in St. Kitt");
            }
            else if (siblings == 1)
            {
                Console.WriteLine(" You will live on a boat.");
            }
            else if (siblings == 2)
            {
                Console.WriteLine(" You will live in Las Vegas.. baby! ");
            }
            else if (siblings == 3)
            {
                Console.WriteLine(" You will live in THE LAND");
            }
            else if (siblings > 3)
            {
                Console.WriteLine("You will live in a teeny tiny house!");
            }
            else
            {
                Console.WriteLine();
            }
            Console.ReadKey();
            }
            {
            }














