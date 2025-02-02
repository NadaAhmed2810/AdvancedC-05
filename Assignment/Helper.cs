using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    internal class Helper
    {
        public static void Reverse(ArrayList Numbers)
        {
            if (Numbers == null || Numbers.Count == 0) return;
            int sz=Numbers.Count;
            for (int i = 0; i < Numbers.Count / 2; i++)
            {
                object Temp = Numbers[i];
                Numbers[i] = Numbers[sz-i-1];
                Numbers[sz - i - 1] = Temp;
            }

        }
        public static void Swap<T>(ref T num1, ref T num2)
        {
            T Temp = num1;
            num1 = num2;
            num2 = Temp;
        }
        public static List<int> GetEvenNumbers(List<int> Numbers)
        {
            List<int> Result= new List<int>();
            for (int i = 0;i < Numbers.Count;i++)
                if (Numbers[i]%2==0)
                    Result.Add(Numbers[i]);
            return Result;
        }
    }
}
