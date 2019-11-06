using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciseB1_Q7
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] first_arr = new int[5];
            int[] second_arr = new int[5];
            int[] third_arr = new int[10];

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("enter "+(i+1)+" number for first array:");
                first_arr[i] = Convert.ToInt32(Console.ReadLine());
            }

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("enter " + (i + 1) + " number for second array:");
                second_arr[i] = Convert.ToInt32(Console.ReadLine());
            }

            first_arr.CopyTo(third_arr,0);
            second_arr.CopyTo(third_arr, 5);
            Array.Sort(third_arr);

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(third_arr[i]);
            }
            
        }
    }
}
