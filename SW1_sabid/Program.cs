using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SW1_sabid
{
    class Program
    {
        static bool IsPrime(int number)
        {
            if (number <= 1) return false;
            for (int i = 2; i <= Math.Sqrt(number); i++)
            {
                if (number % i == 0) return false;
            }
            return true;
        }

        public static (double peso, double yen) ConvertDollar(double dollar)
        {
            double peso = dollar * 57.17;
            double yen = dollar * 146.67;
            return (peso, yen);
        }

        static void Main(string[] args)
        {
            Console.Write("Enter string of numbers (space separated): ");
            string input = Console.ReadLine();
            string[] numbers = input.Split(' ');

            int count = 1;
            foreach (string numStr in numbers)
            {
                if (int.TryParse(numStr, out int n))
                {
                    if (IsPrime(n))
                        Console.WriteLine($"{count}.  {n}\tPrime");
                    else
                        Console.WriteLine($"{count}.  {n}\tComposite");
                    count++;
                }
            }

            Console.WriteLine("\n=================================\n");

            Console.Write("Enter currency in ($): ");
            string currencyInput = Console.ReadLine();
            string[] dollarStrings = currencyInput.Split(',');

            Console.WriteLine("\nDollar($)\tPhil Peso(P)\tJpn Yen(Y)");
            foreach (string dollarStr in dollarStrings)
            {
                if (double.TryParse(dollarStr, out double dollar))
                {
                    var result = ConvertDollar(dollar);
                    Console.WriteLine($"{dollar}\t\t{result.peso:F2}\t\t{result.yen:F2}");
                }
            }
            Console.ReadKey();
        }
    }

}
