using System;
namespace f0rtnite
{
    class Program
    {
        static void Main(string[] args)
        {
            double markLses = double.Parse(Console.ReadLine());
            double j = double.Parse(Console.ReadLine());
            Console.WriteLine(pot(markLses, j));
        }
        static double pot(double markLses, double j)
        {
            double svar = 1;
            for(double i = 0; i < j; i++) 
            {
                svar = markLses *= svar;
            }
            return svar;
        }
    }
}