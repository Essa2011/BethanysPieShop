using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciseB1_Q12
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rand1 = new Random();
            var num  = rand1.Next(1,6);
            var num2 = rand1.Next(1, 6);

            Console.WriteLine(Convert.ToInt32(num));
            Console.WriteLine(Convert.ToInt32(num2));
        }

        
    }
}
