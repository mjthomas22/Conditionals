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
            double total = sub-(sub * discount);
            Console.WriteLine("Reservation Name : {0}", reserveName);
            Console.WriteLine("Subtotal: ${0}", sub);
            Console.WriteLine("Total after discount ${0}", total);
        }
    }
}
