using System;
using System.Collections.Generic;
using System.Text;

namespace Extention
{
    internal static class StringExtentions
    {
        public static bool IsConsistOfDigits(this string str)
        {
            foreach (var chr in str)
            {
                if(!char.IsDigit(chr))
                    return false;
            }

            return true;
        }

        public static bool HasDigit(this string str)
        {
            if(str != null)
            {
                foreach (var chr in str)
                {
                    if (char.IsDigit(chr))
                        return true;
                }
            }
            return false;
        }

        public static bool IsEven(this int num)
        {
            return num % 2 == 0;
        }

        public static int Add(this int num1,int num2)
        {
            return num1 + num2;
        }

        public static void Show(this Human human)
        {
            Console.WriteLine($"FullName: {human.Name} {human.Surname}");
        }
    }
}
