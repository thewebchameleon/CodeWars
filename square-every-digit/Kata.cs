using System;

namespace square_every_digit
{
    /// <summary>
    /// https://www.codewars.com/kata/5264d2b162488dc400000001
    /// </summary>
    class Kata
    {

        public static int SquareDigits(int n)
        {
            var outputString = string.Empty;
            foreach (var numberChar in n.ToString())
            {
                var number = int.Parse(numberChar.ToString());
                outputString += Math.Pow(number, 2);
            }
            return int.Parse(outputString);
        }

    }
}
