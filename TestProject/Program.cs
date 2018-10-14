using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProject
{
    class Program
    {
        const double PI = 3.1415;

        static double Pow(double value, int power)
        {
            double tmp = value;

            for (int i = 1; i < power; i++)
            {
                tmp *= value;
            }

            return tmp;
        }

        static void Main(string[] args)
        {
            Console.WriteLine(Pow(PI, 2));
        }
    }
}
