using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Extension_Method_Example
{
    public static class StringCap
    {
        public static bool IsCap(this string s)
        {
            if (string.IsNullOrEmpty(s))
            {
                return false;
            }

            return char.IsUpper(s[0]);
        }
    }
}
