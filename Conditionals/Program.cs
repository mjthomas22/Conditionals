using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conditionals
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is the name on your reservation");
            string reserveName = Console.ReadLine();

            Console.WriteLine("How many people are in your party");
            int numberOfPeople = int.Parse(Console.ReadLine());

            Console.WriteLine("What was the cost per meal?");
            double amountEach = double.Parse(Console.ReadLine());
            double sub = numberOfPeople * amountEach;



            double discount;

            if (sub >= 50)
            {
                discount = .10;
                Console.WriteLine("You recieved a 10% discount");
            }
            else
            {
                discount = .05;
                Console.WriteLine("You recieved a 5% discount");
            }
            double total = sub - (sub * discount);
            Console.WriteLine("Reservation Name : {0}", reserveName);
            Console.WriteLine("Subtotal: ${0}", sub);
            Console.WriteLine("Total after discount ${0}", total);


            Console.WriteLine("To find out out what age category you belong in please enter your age.");
            int age = int.Parse(Console.ReadLine());

            if (age >= 0 && age <= 2)
            {
                Console.WriteLine("Stil in Mama's Arms");
            }

            else if (age >= 3 && age <= 4)
            {
                Console.WriteLine("Preschool Maniac");
            }

            else if (age >= 5 && age <= 11)
            {
                Console.WriteLine("Elementary School");
            }

            else if (age >= 12 && age <= 14)
            {
                Console.WriteLine("Middle School");
            }

            else if (age >= 15 && age <= 18)
            {
                Console.WriteLine("High School");
            }

            else if (age >= 19 && age <= 22)
            {
                Console.WriteLine("College");
            }

            else if (age >= 23 && age <= 65)
            {
                Console.WriteLine("Working for the the Man");
            }

            else if (age >= 66 && age <= 100)
            {
                Console.WriteLine("The Golden Years");
            }

            else
            {
                Console.WriteLine("This program is for humans.");
            }

            Console.WriteLine("Please type out the number you want to view in numeric form");
            String number = Console.ReadLine();

            switch (number)
            {
                case "zero":
                    Console.WriteLine("0");
                    break;
                case "one":
                    Console.WriteLine("1");
                    break;
                case "two":
                    Console.WriteLine("2");
                    break;
                case "three":
                    Console.WriteLine("3");
                    break;
                case "four":
                    Console.WriteLine("4");
                    break;
                case "five":
                    Console.WriteLine("5");
                    break;
                case "six":
                    Console.WriteLine("6");
                    break;
                case "seven":
                    Console.WriteLine("7");
                    break;
                case "eight":
                    Console.WriteLine("8");
                    break;
                case "nine":
                    Console.WriteLine("9");
                    break;
                case "ten":
                    Console.WriteLine("10");
                    break;

            }



        }
    }
}
