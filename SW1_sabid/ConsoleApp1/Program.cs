using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter row: ");
        int row = int.Parse(Console.ReadLine());

        Console.Write("Enter col: ");
        int col = int.Parse(Console.ReadLine());

        int[,] matrix = new int [row, col];

        Console.Write("Enter elements: ");

        for (int i = 0; i < row; i++){
            for(int j = row; j <col; j++)
            {
                Console.Write($"elements [{i + 1}, {j + 1}]");
                matrix[i, j] = int.Parse(Console.ReadLine());
            }
        }
        Console.ReadKey();

    }
}
