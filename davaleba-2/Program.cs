using System;

namespace Davaleba_2
{
    class Program
    {
        static void Main(string[] args)
        {
            
        }

        private static int minSplit(int amount) 
        {
            int[] array = { 50, 20, 10, 5, 1 };
            int minSplit = 0;
            if (amount > 0)
            {
                int i = 0;
                while (i < array.Length)
                {
                    if (amount - array[i] == 0)
                    {
                        minSplit++;
                        return minSplit;
                    }
                    else if (amount - array[i] > 0)
                    {
                        amount -= array[i];
                        minSplit++;
                    }
                    else
                    {
                        i++;
                    }
                }
                return minSplit;
            }
            else 
            {
                return minSplit;
            }
        }
    }
}
