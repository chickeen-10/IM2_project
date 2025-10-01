using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW3_sabid
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter string: ");
            string input = Console.ReadLine();


            string[] words = input.Split(new char[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries);

            foreach (string word in words)
            {
                Dictionary<char, int> freq = GetFrequency(word);

                List<string> output = new List<string>();
                foreach (var item in freq)
                {
                    output.Add($"{item.Key}={item.Value}");
                }
                Console.WriteLine(string.Join(", ", output));
            }

            Console.ReadKey();
        }

        static Dictionary<char, int> GetFrequency(string str)
        {
            Dictionary<char, int> dict = new Dictionary<char, int>();

            foreach (char c in str)
            {
                if (dict.ContainsKey(c))
                    dict[c]++;
                else
                    dict[c] = 1;
            }
            return dict;
        }
    }
}
