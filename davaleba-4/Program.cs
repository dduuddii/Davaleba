using System;
using System.Text;

namespace Davaleba_4
{
    class Program
    {
        static void Main(string[] args)
        {
            string x = "xasfa)(asda)d()sad(asdas)";
            Console.WriteLine(isProperly(x));
            Console.ReadKey();
        }

        public static bool isProperly(string sequence) 
        {
            bool isProperly = false;
            char start = '(';
            char end = ')';

            char[] tempArray = sequence.ToCharArray();
            var builder = new StringBuilder();

            for (int i = 0; i < tempArray.Length; i++)
            {
                if (start == tempArray[i] || end == tempArray[i])
                {
                    builder.Append(tempArray[i]);
                }
            }
            sequence = builder.ToString();
            char[] array = sequence.ToCharArray();

            if (start == array[0])
            {
                for (int i = 0; i < array.Length; i++)
                {
                    if (start == array[i] && i%2 == 0)
                    {
                        isProperly = true;
                    }
                    else if (end == array[i] && i % 2 == 1)
                    {
                        isProperly = true;
                    }
                    else
                    {
                        isProperly = false;
                        return isProperly;
                    }
                }
            }
            return isProperly;
        }
    }
}

