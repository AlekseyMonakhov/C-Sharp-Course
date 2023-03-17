using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW7
{
    public class NumConverter
    {
     
        public static List<int> convertDoubleToArray(double number)
        {
            List<int> result = new List<int>();
            string str = number.ToString().Replace(",", "");
            for (int i = 0; i < str.Length; i++)
            {
                result.Add(CharUnicodeInfo.GetDigitValue(str[i]));
            }

            return result;
        }
    }
}
