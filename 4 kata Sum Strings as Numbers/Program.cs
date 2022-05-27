using System;
using System.Text;
using System.Linq;

namespace _4_kata_Sum_Strings_as_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
           string a = "00103";
            string b = "08567";
            Console.WriteLine(Kata.sumStrings(a,b));
        }

    }
    public static class Kata
    {
        public static string sumStrings(string a, string b)
        {
            char[] charMax = a.Length > b.Length ? a.TrimStart('0').ToCharArray().Reverse().ToArray() : b.TrimStart('0').ToCharArray().Reverse().ToArray();
            char[] charMin = a.Length > b.Length ? b.TrimStart('0').ToCharArray().Reverse().ToArray() : a.TrimStart('0').ToCharArray().Reverse().ToArray();

            int sumNum = 0;

            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < charMin.Length; i++)
            {
                sumNum = sumNum + charMax[i] + charMin[i] - 2 * '0';
                if (sumNum < 10)
                {
                    sb.Append(sumNum);
                    sumNum = 0;
                }
                else
                {
                    sb.Append(sumNum - 10);
                    sumNum = 1;
                }
            }
            for (int i = charMin.Length; i < charMax.Length; i++)
            {
                sumNum = sumNum + charMax[i] - '0';
                if (sumNum < 10)
                {
                    sb.Append(sumNum);
                    sumNum = 0;
                }
                else
                {
                    sb.Append(sumNum - 10);
                    sumNum = 1;
                }
            }
            if (sumNum == 1)
            {
                sb.Append(sumNum);
            }
            return string.Concat(sb.ToString().Reverse().ToArray());


        }
    }
}
