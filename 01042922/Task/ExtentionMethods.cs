using System;
using System.Collections.Generic;
using System.Text;

namespace Task
{
    internal static class ExtentionMethods
    {
        public static bool HasDigit(this string str)
        {
            if (!String.IsNullOrWhiteSpace(str))
            {
                foreach (var item in str)
                {
                    if(char.IsDigit(item))
                        return true;
                }
            }

            return false;
        }
    }
}
