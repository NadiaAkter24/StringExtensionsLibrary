using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringExtensionsLibrary
{
    public static class StringExtensions
    {
        public static bool StartsWithUpperCase(this string str)
        {
            if (string.IsNullOrEmpty(str))
                return false;

            return char.IsUpper(str[0]);
        }
    }
}
