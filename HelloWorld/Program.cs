using System;
using System.Runtime.CompilerServices;

namespace Helloworld
{
    public class Program
    {
        public static void Main(string[] args)
        {
            double a = 20;
            double b = 10;
            Math math = new Math();
            double Addresult = math.Add(a, b);

            double substractResult = math.Substract(a, b);

            Console.WriteLine(Addresult.ToString());

            Console.WriteLine(substractResult.ToString());
        }
    }
}
