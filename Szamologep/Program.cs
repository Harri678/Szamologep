using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Szamologep
{
    internal class Program
    {
        public double Osszeadas(double a, double b)
        {
            return a + b;
        }
        public double Kivonas(double a, double b)
        {
            return a - b;
        }
        public double Osztas(double a, double b)
        {
            return a / b;
        }
        public double Szorzas(double a, double b)
        {
            return a * b;
        }
        public double Szazalek(double a, double b)
        {
            return a * b / 100;
        }

        public void Indit()
        {
            Console.WriteLine("Kerem adja meg az elso szamot: ");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Kerem adja meg a masodik szamot: ");
            double b = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Az elvegezendo muvelet jele: ");
            string muvelet = Console.ReadLine();
            switch (muvelet)
            {
                case "+":
                    Console.WriteLine(Osszeadas(a, b));
                    break;
                case "-":
                    Console.WriteLine(Kivonas(a, b));
                    break;
                case "*":
                    Console.WriteLine(Szorzas(a, b));
                    break;
                case "/":
                    Console.WriteLine(Osztas(a, b));
                    break;
                case "%":
                    Console.WriteLine(Szazalek(a, b));
                    break;
                default:
                    Console.WriteLine("Hibas muvelet");
                    break;
            }
        }

        static void Main(string[] args)
        {
            Program program = new Program();
            program.Indit();
        }
    }
}
