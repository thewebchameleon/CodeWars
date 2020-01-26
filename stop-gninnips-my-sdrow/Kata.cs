using System;

namespace stop_gninnips_my_sdrow
{
    /// <summary>
    /// https://www.codewars.com/kata/546e2562b03326a88e000020
    /// </summary>
    public class Kata
    {

        public static string SpinWords(string sentence)
        {
            var outputString = string.Empty;
            foreach (var word in sentence.Split(' '))
            {
                var w = word;
                if (word.Length >= 5)
                {
                    w = Reverse(word);
                }
                outputString += $"{w} ";
            }
            return outputString.TrimEnd();
        }

        public static string Reverse(string s)
        {
            char[] charArray = s.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }

    }
}
