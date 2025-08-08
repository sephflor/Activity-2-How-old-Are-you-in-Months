using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace How_old_are_you_in_months
{
    internal class Program
    {
        static void Main(string[] args)
        { 
            //Ask user to input age
            Console.Write("Enter your age(1-120): ");
            int age = int.Parse(Console.ReadLine());

            // Convert age to months
            int age_in_months = age * 12;

            //If the age is between 1 and 120 print age in months
            if (age >= 1 && age <= 120)
            {
                Console.WriteLine("You are " + age_in_months + " months old");
            }
            else
            {   
                Console.WriteLine("Pls. enter age between 1 and 120");
            }


        }
    }
}
