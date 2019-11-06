using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciseB1_Q10
{
    class Program
    {
        static void Main(string[] args)
        {
            char ch;
            int side;

            Console.WriteLine("enter a chracter: ");
            ch = Convert.ToChar(Console.ReadLine());

            Console.WriteLine("enter a number: ");
            side = Convert.ToInt32(Console.ReadLine());

            Square(side, ch);


        }

        public static string Square(int side , char ch)
        {
            for (int i = 0; i < side; i++)
            {
                for (int j = 0; j < side; j++)
                {
                    Console.Write(ch);
                }
                Console.WriteLine();
            }
            return ch.ToString();
        }
    }
}
