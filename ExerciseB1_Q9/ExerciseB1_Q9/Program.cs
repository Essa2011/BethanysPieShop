using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciseB1_Q9
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter a base number");
            int base_num = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("enter a power number");
            int power_num = Convert.ToInt32(Console.ReadLine());

            IntegerPower(base_num, power_num);




        }

        public static int IntegerPower(int base_num, int power_num)
        {
            int result = Convert.ToInt32(Math.Pow(base_num, power_num));
            Console.WriteLine(result);
            
            return result;
            
           
        }
    }
}
