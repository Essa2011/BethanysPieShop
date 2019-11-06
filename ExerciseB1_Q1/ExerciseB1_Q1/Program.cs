using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciseB1_Q1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a degree:");
            var degree = Convert.ToInt32(Console.ReadLine());

            if (degree < 100 && degree > 0)
            {
                if (degree >= 95)
                    Console.WriteLine("the grade of the student is: A+");


                else if (degree <= 95 && degree >= 90)
                    Console.WriteLine("the grade of the student is: A");

                else if (degree < 90 && degree >= 85)
                    Console.WriteLine("the grade of the student is: B+");

                else if (degree < 85 && degree >= 80)
                    Console.WriteLine("the grade of the student is: B");

                else if (degree < 80 && degree >= 75)
                    Console.WriteLine("the grade of the student is: C+");

                else if (degree < 75 && degree >= 70)
                    Console.WriteLine("the grade of the student is: C");

                else if (degree < 70 && degree >= 65)
                    Console.WriteLine("the grade of the student is: D+");

                else if (degree < 65 && degree >= 60)
                    Console.WriteLine("the grade of the student is: D");

                else if (degree < 60)
                    Console.WriteLine("the grade of the student is : F");

            }

        }
    }
}
