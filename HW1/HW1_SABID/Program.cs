using System;

class Program
{
    static void Main()
    {
        while (true)
        {
            Console.Write("Enter string: ");
            string input = Console.ReadLine();

            if (input == "*")
                break;

            string original = input;
            string lowercaseOriginal = input.ToLower();
            string reversed = ReverseString(lowercaseOriginal);
            bool isPalindrome = IsPalindrome(lowercaseOriginal, reversed);

            Console.WriteLine("Original String\t\tReversed String\t\tPalindrome?");
            Console.WriteLine($"{original,-15}\t\t{reversed,-15}\t\t{(isPalindrome ? "Yes" : "No")}");
        }
        Console.WriteLine("\n//End execution");
        Console.ReadKey();
    }

    static string ReverseString(string str)
    {
        char[] charArray = str.ToCharArray();
        int left = 0;
        int right = charArray.Length - 1;

        while (left < right)
        {
            char temp = charArray[left];
            charArray[left] = charArray[right];
            charArray[right] = temp;
            left++;
            right--;
        }
        return new string(charArray);
    }

    static bool IsPalindrome(string original, string reversed)
    {
        return original == reversed;
    }
}