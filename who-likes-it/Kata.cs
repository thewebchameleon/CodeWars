using System;
using System.Collections.Generic;
using System.Text;

namespace who_likes_it
{
    /// <summary>
    /// https://www.codewars.com/kata/5266876b8f4bf2da9b000362/train/csharp
    /// </summary>
    class Kata
    {

        public static string Likes(string[] name)
        {
            var outputString = string.Empty;

            if (name.Length == 0)
            {
                outputString = "no one likes this";
            }
            else if (name.Length == 1)
            {
                outputString = $"{name[0]} likes this";
            }
            else if (name.Length == 2)
            {
                outputString = $"{name[0]} and {name[1]} like this";
            }
            else if (name.Length == 3)
            {
                outputString = $"{name[0]}, {name[1]} and {name[2]} like this";
            } else
            {
                outputString = $"{name[0]}, {name[1]} and {name.Length - 2} others like this";
            }

            return outputString;
        }

    }
}
