using System;

class w1
{
    static double sum = 0;
    public static void Main(string[] args)
    {
        Console.Write("number : ");
        double num = double.Parse(Console.ReadLine());
        Console.WriteLine(funtionMath(num));
    }

    static double funtionMath(double n)
    {
        if (Math.Pow(n, 2) > 4)
        {
            sum += 1 + funtionMath(n - (4 * Math.Abs(n) / n));
        }
        else
        {
            sum += 2;
        }
        return sum;
    }
}