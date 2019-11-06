using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciseB1_Q3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter a number:");
            int first_num = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("enter another number:");
            int second_num = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("enter an arthimitic operation:");
            var opr = Console.ReadLine();

            int result =0;
            switch (opr)
            {
                case "+":
                     result = first_num + second_num;
                    break;

                case "-":
                     result = first_num - second_num;
                    break;

                case "*":
                    result = first_num * second_num;
                    break;

                case "/":
                    result = first_num / second_num;
                    break;
            }

            Console.WriteLine("the result: "+result);


        }
    }
}
