using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciseB1_Q8
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[10];
            //int[] arr2 = new int[10];
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine("enter " + (i+1) + " number");
                arr[i] = Convert.ToInt32(Console.ReadLine());
                //arr2[i] = -1;
            }

            /*foreach (var number in arr.GroupBy(x => x))
            {
                Console.WriteLine(number.Key + " repeated " + (number.Count()) + " time");
            }*/



            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i-1] != arr[0] && arr[i - 1] == arr[i])
                {
                    continue;
                }
                else
                {



                    int count = 0;
                    for (int j = 0; j < arr.Length; j++)
                    {

                        if (arr[i] == arr[j])
                        {
                            count++;

                        }


                    }

                    Console.WriteLine();
                    //arr.Distinct();

                    Console.WriteLine(arr[i] + " repeated " + count + " times.");

                }
            }
        }
    }
}
