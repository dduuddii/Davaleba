using System;

namespace Davaleba_5
{
    class Program
    {
        static void Main(string[] args)
        {
            int z = 4;
            Console.WriteLine(countVariants(z));
            Console.ReadKey();
        }

        public static int x(int y) 
        {
            if (y <= 1)
            {
                return y;
            }
            else 
            {
                return x(y - 1) + x(y - 2);
            }
        }

        public static int countVariants(int stearsCount) 
        {
            return x(stearsCount + 1);
        }
    }
}
