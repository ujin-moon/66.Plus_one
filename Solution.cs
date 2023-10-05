using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _66._Plus_One
{
    public class Solution
    {
        public int[] PlusOne(int[] digits)
        {
            int i = digits.Length - 1;
            digits[digits.Length - 1]++;
            while (i > 0)
            {
                if ((digits[i] == 10) && (i != 0))
                {
                    digits[i] = 0;
                    digits[i - 1]++;
                }
                i--;
            }
            if ((digits[i] == 10) && (i == 0))
            {
                digits[i] = 0;
                int[] arr = new int[digits.Length + 1];
                arr[0] = 1;
                Array.Copy(digits, 0, arr, 1, digits.Length);
                return arr;
            }
            return digits;
        }
    }
}
