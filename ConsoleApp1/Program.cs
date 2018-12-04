using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        private static double taylor(double x, out int steps, double eps = Double.Epsilon)
        {
            if (Math.Abs(x)> 1) throw new ArgumentException();
            steps = 0;
            int k = 0;
            double comp = x;
            double sum = comp;
            while (Math.Abs(comp) > eps)
            {
                  k ++;
                comp = (Math.Pow(x, 2 * k + 1)) / (2 * k + 1);
                sum += comp;
                steps++;
            }


            return 2 * sum;
        }
        private static void taylorTable(double x1, double x2, double dx, double eps)
        {
            if (x1 >= x2) throw new ArgumentException();
            Console.WriteLine("Prubluzene znachenna\t\tTochne znachenna\t\t\tdodankiv");
            for (double d = x1; d < x2; d += dx)
            {
                int steps;
                double y = taylor(d, out steps, eps);
                double res = Math.Log((1 + d) / (1 - d));

                Console.WriteLine("{0,-25}\t{1,-25}\t{2}", res, y, steps);
            }
        }

        static void Main(string[] args)
        {
            taylorTable(0, 0.9, 0.1, 0.0000001);
            Console.ReadLine();
        }
    }
}
