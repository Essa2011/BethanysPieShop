using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciseB1_Q4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your salary:");
            int salary = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("enter your category:");
            string cat = Console.ReadLine();

            var tax = 0f;
            switch (cat.ToUpper())
            {
                case "A":
                    tax = 0.05f * salary;
                    Console.WriteLine("the tax of your salary: "+ tax);
                    break;

                case "B":
                    tax = 0.10f * salary;
                    Console.WriteLine("the tax of your salary: " + tax);
                    break;

                case "C":
                    tax = 0.15f * salary;
                    Console.WriteLine("the tax of your salary: " + tax);
                    break;
            }
        }
    }
}
