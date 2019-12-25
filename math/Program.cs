using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace math
{
    class Program
    {
        static void Main(string[] args)
        {
            //Celi deo broja
            float number = 225.75f;
            Console.WriteLine("Celi deo broja {0} je {1}\n",
                              number, Math.Truncate(number));

            //Manji broj
            int number1 = 8025;
            int number2 = 73;

            Console.WriteLine("Manji broj od broja {0} i broja {1} je {2}",
                number1, number2, Math.Min(number1, number2));

            //Veci broj
            int number3 = 8025;
            int number4 = 73;

            Console.WriteLine("Veci broj od broja {0} i broja {1} je {2}",
                number1, number2, Math.Max(number1, number2));

            //Apsolutna vrednost
            int number5 = -6844;

            Console.WriteLine("Pocetna vrednost = {0}", number);
            Console.WriteLine("Apsolutna vrednost = {0}\n", Math.Abs(number));

            //Stepenovanje
            const double source = 3;
            const double exp = 2;
            double result = Math.Pow(source, exp);

            Console.WriteLine("Pow({0}, {1}) = {2}\n", source, exp, result);

            //Logaritam broja
            double log = 12.48D;

            Console.WriteLine("Log broja {0} je {1}", log, Math.Log(log));

            //Sin

            double number6 = 82.55;

            Console.WriteLine("Sin broja {0} je {1}", number, Math.Sin(number));

            //Cos
            int number7 = 82;

            Console.WriteLine("Cos broja {0} je {1}", number, Math.Cos(number));


            Console.ReadLine();
            


        }
    }
}
