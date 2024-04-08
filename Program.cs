namespace playground
{
    using System;
    internal class Program
    {
        static void Main(string[] args)
        {
            int limitOne, limitTwo, n, min, max;

            Console.Write("Limit1: ");
            limitOne = Convert.ToInt32(Console.ReadLine());
            Console.Write("Limit2: ");
            limitTwo = Convert.ToInt32(Console.ReadLine());
            Console.Write("Integer: ");
            n = Convert.ToInt32(Console.ReadLine());

            min = limitOne < limitTwo ? limitOne : limitTwo;
            max = limitOne > limitTwo ? limitOne : limitTwo;

            if (n < min)
            {
                Console.WriteLine("You have entered {0} which is lower than {1} which is the minimum", n, min);
                Console.WriteLine("Resulting integer: {0}", min);

            }
            else if (n > max)
            {
                Console.WriteLine("You have entered {0} which is greater than {1} which is the maximum", n, max);
                Console.WriteLine("Resulting integer: {0}", max);
            }
        }
    }
}
