using System;

class w2
{
    static double sum = 0;
    public static void Main(string[] args)
    {
        Console.Write("number : ");
        double num = double.Parse(Console.ReadLine());
        Console.WriteLine(funtionMath(num));
    }
    static double funtionMath(double x)
    {
        if (x > -1 && x <= 0)
        {
            sum = sum + Math.Sqrt(1 - Math.Pow(x, 2));
        }
        else if (x > 0 && x <= 1)
        {
            sum = sum + (-(Math.Sqrt(1 - Math.Pow(x, 2))));
        }
        else if (x <= -1)
        {
            sum = sum + funtionMath(x + 2);
        }
        else if (x > 1)
        {
            sum = sum + funtionMath(x - 2);
        }
        return sum;
    }
}