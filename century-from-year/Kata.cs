using System;
using System.Collections.Generic;
using System.Text;

namespace century_from_year
{
    /// <summary>
    /// https://www.codewars.com/kata/5a3fe3dde1ce0e8ed6000097
    /// </summary>
    class Kata
    {

        public static int СenturyFromYear(int year)
        {
            return ((int)(year / 100)) + ((year % 100 == 0) ? 0 : 1);
        }

    }
}
