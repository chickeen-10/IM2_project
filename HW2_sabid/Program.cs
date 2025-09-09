using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW2_sabid
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter row: ");
            int row = int.Parse(Console.ReadLine());

            Console.Write("Enter col: ");
            int col = int.Parse(Console.ReadLine());

            List<List<double>> numbers = new List<List<double>>();

            for (int i = 0; i < row; i++)
            {
                Console.WriteLine($"Row {i + 1}");
                List<double> temp = new List<double>();

                for (int j = 0; j < col; j++)
                {
                    Console.Write($"Enter number{j + 1}: ");
                    double num = double.Parse(Console.ReadLine());
                    temp.Add(num);
                }

                numbers.Add(temp);
            }

            Console.WriteLine("\nThe numbers are:");
            double sum = 0;
            int count = 0;



            foreach (var r in numbers)
            {
                foreach (var n in r)
                {
                    Console.Write(n.ToString("F1") + " ");
                    sum += n;
                    count++;
                }
                Console.WriteLine();
            }

            double average = sum / count;

            Console.WriteLine($"\nSum: {sum}; Average: {average}");
            Console.ReadKey();
        }
    }
}
