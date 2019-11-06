using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciseB1_Q5
{
    class Program
    {
        
        static void Main(string[] args)
        {
            var max = 0;
            var i = 0;
            int[] salary = new int[5];
            string[] names = new string[5];
            for( i =0 ; i < 5; i++)
            {
                Console.WriteLine("enter "+(i+1) +" salary:");
                salary[i] = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("enter " + (i + 1) + " employee name:");
                names[i] = Console.ReadLine();

                

                if(salary[i]> max)
                {
                    max = salary[i];                    
                }
                
            }

            for(i = 0; i<5; i++)
            {
                if(salary[i] == max)
                {
                    Console.WriteLine("employee with largest salary is: "+names[i] + " salary: "+salary[i]);
                }
            }
            
        }
    }
}
