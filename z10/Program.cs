using System;

class Program
{
    static int SumOf2DArray(int[,] array)
    {
        int sum = 0;
        foreach (int num in array)
        {
            sum += num;
        }
        return sum;
    }

    static void Main()
    {
        int[,] twoDArray = { { 1, 2, 3 }, { 4, 5, 6 } };
        Console.WriteLine($"Сумма всех элементов двумерного массива: {SumOf2DArray(twoDArray)}");
    }
}
