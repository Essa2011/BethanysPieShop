using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciseB1_Q2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter your birth day :");
            var day = Convert.ToInt32(Console.ReadLine());
            
            Console.WriteLine("enter your birth month :");
            var month = Convert.ToInt32(Console.ReadLine());

            

                switch (month)
                {
                    case 1:
                        if (day < 20)
                        {
                            Console.WriteLine("Capricornus");
                        }
                        else
                        {
                            Console.WriteLine("Aquarius");
                        }
                        break;

                    case 2:
                        if (day < 19)
                        {
                            Console.WriteLine("Aquarius");
                        }
                        else
                        {
                            Console.WriteLine("Pisces");
                        }
                        break;

                    case 3:
                        if (day < 21)
                        {
                            Console.WriteLine("Pisces");
                        }
                        else
                        {
                            Console.WriteLine("Aries");
                        }
                        break;

                    case 4:
                        if (day < 20)
                        {
                            Console.WriteLine("Aries");
                        }
                        else
                        {
                            Console.WriteLine("Taurus");
                        }
                        break;

                    case 5:
                        if (day < 21)
                        {
                            Console.WriteLine("Taurus");
                        }
                        else
                        {
                            Console.WriteLine("Gemini");
                        }
                        break;

                    case 6:
                        if (day < 21)
                        {
                            Console.WriteLine("Gemini");
                        }
                        else
                        {
                            Console.WriteLine("Cancer");
                        }
                        break;

                    case 7:
                        if (day < 23)
                        {
                            Console.WriteLine("Cancer");
                        }
                        else
                        {
                            Console.WriteLine("Leo");
                        }
                        break;

                    case 8:
                        if (day < 23)
                        {
                            Console.WriteLine("Leo");
                        }
                        else
                        {
                            Console.WriteLine("Virgo");
                        }
                        break;

                    case 9:
                        if (day < 22)
                        {
                            Console.WriteLine("Virgo");
                        }
                        else
                        {
                            Console.WriteLine("Libra");
                        }
                        break;

                    case 10:
                        if (day < 23)
                        {
                            Console.WriteLine("Libra");
                        }
                        else
                        {
                            Console.WriteLine("Scorpio");
                        }
                        break;

                    case 11:
                        if (day < 22)
                        {
                            Console.WriteLine("Scorpio");
                        }
                        else
                        {
                            Console.WriteLine("Sagittarius");
                        }
                        break;

                    case 12:
                        if (day < 22)
                        {
                            Console.WriteLine("Sagittarius");
                        }
                        else
                        {
                            Console.WriteLine("Capricorn");
                        }
                        break;
                }

                }
            
    }
}
