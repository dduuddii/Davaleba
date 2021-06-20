using System;

namespace Davaleba_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 80, 11, 50, 77, 49, 70, 24, 9, 1, 5, 6, 7, 4, 2, 3 };

            Console.WriteLine(MyTools.notContains(array));
            Console.ReadKey();

        }
    }

    static class MyTools
    {
        public static void Sort(int[] array)
        {

            int temp;

            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 0; j < array.Length - (1 + i); j++)
                {
                    if (array[j] > array[j + 1])
                    {
                        temp = array[j + 1];
                        array[j + 1] = array[j];
                        array[j] = temp;
                    }
                }

            }

        }

        public static int notContains(int[] array) 
        {
            int notContains = 1;

            MyTools.Sort(array);
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] != notContains)
                {
                    return notContains;
                }
                else 
                {
                    notContains++;
                }
            }
            return notContains;
        }
    }
}
