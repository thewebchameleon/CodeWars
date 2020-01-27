using System;
using System.Linq;

namespace remove_all_marked_elements_of_list
{
    /// <summary>
    /// https://www.codewars.com/kata/563089b9b7be03472d00002b/
    /// </summary>
    class Kata
    {

        public static int[] Remove(int[] integerList, int[] valuesList)
        {
            return integerList.Where(x => !valuesList.Contains(x)).ToArray();
        }

    }
}
