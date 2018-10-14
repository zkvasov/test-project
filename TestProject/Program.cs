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

        static void Main(string[] args)
        {
            int a = 2;
            double tmp = PI;

            for (int i = 1; i < a; i++)
            {
                tmp *= PI;
            }

            Console.WriteLine(tmp);
        }
    }
}
