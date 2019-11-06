using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciseB1_Q6
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = new List<int>();

            while (numbers.Count < 6)
            {
                Console.WriteLine("enter a numbers :");
                var number = Convert.ToInt32(Console.ReadLine());

                    if (!numbers.Contains(number))
                    {
                        numbers.Add(number);
                        
                    }
                else
                {
                    Console.WriteLine("the number already exist");
                }

            }
            foreach (var number in numbers)
            {
                Console.WriteLine("\n"+number);
            }
            

        }
    }
}
