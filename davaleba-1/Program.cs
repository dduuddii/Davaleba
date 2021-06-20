using System;

namespace Davaleba_1
{
    class Program
    {
        static void Main(string[] args)
        {
            
        }

        private static bool IsPalindrome(string text)
        {
            bool IsPalindrome = true;
            if (text.Length > 0)
            {
                for (int i = 0; i < text.Length / 2; i++)
                {
                    if (text.Substring(i, 1) != text.Substring(text.Length - (i + 1), 1))
                    {
                        IsPalindrome = false;
                    }
                }
            }
            else
            {
                IsPalindrome = false;
            }
            return IsPalindrome;
        }
    }
}
