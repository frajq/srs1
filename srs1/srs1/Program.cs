using System;

class Program
{
    static void Main()
    {
        Console.Write("Введите целое число для вычисления факториала: ");
        int number = Convert.ToInt32(Console.ReadLine());

        long factorial = Factorial(number);

        Console.WriteLine($"Факториал числа {number} равен {factorial}");
    }

    static long Factorial(int n)
    {
        if (n < 0)
            throw new ArgumentException("Факториал отрицательного числа не существует.");
        if (n == 0) return 1;

        long result = 1;
        for (int i = 1; i <= n; i++)
        {
            result *= i;
        }
        return result;
    }
}