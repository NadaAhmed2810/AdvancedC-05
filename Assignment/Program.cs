using System.Collections;

namespace Assignment
{
    internal class Program
    {
        public static int FirstNonRepeatedChar(string s)
        {
            s = s.ToLower();
            int res = -1;
            Dictionary<Char, int> dict = new Dictionary<Char, int>();
            if (s != null)
            {
                for (int i = 0; i < s.Length; i++)
                {
                    if (dict.ContainsKey(s[i]))
                    {
                        dict[s[i]]++;
                    }
                    else
                    {
                        dict[s[i]] = 1;
                    }
                }
                for (int i = 0; i < s.Length; i++)
                {
                    if (dict[s[i]] == 1)
                    {
                        res = i;
                        return res;
                    }
                }
            }
            return res;
        }
        static void Main(string[] args)
        {
            #region Q1:You are given an ArrayList containing a sequence of elements. try to reverse the order of elements in the ArrayList in-place(in the same arrayList) without using the built-in Reverse. Implement a function that takes the ArrayList as input and modifies it to have the reversed order of elements.
            //ArrayList Numbers = new ArrayList () { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            //Helper.Reverse(Numbers);
            //for (int i = 0; i < Numbers.Count; i++)
            //{
            //    Console.WriteLine(Numbers[i]);
            //}
            //ArrayList Names = new ArrayList() {"Nada","Nour" ,"Noura","Nadeen"};
            //Helper.Reverse(Names);
            //for (int i = 0;i < Names.Count; i++)
            //{
            //    Console.WriteLine(Names[i]);
            //}

            #endregion
            #region Q2:You are given a list of integers. Your task is to find and return a new list containing only the even numbers from the given list.
            //List<int>Numbers= new List<int>() {1,2,3,4,5,6,7,8,9,10 };
            //List<int> EvenNumbers=Helper.GetEvenNumbers(Numbers);
            //for(int i=0;i<EvenNumbers.Count;i++) 
            //    Console.WriteLine(EvenNumbers[i]);
            #endregion
            #region Q3:FixedSizeList<T> 
            //FixedSizeList<double> FixedSizeList = new FixedSizeList<double>(10);
            //double x = 1;
            //for (int i = 0; i < 11; i++)
            //{
            //    try
            //    {
            //        FixedSizeList.Add(x += .5);
            //    }
            //    catch
            //    {
            //        Console.WriteLine("List Is Full");
            //    }

            //}
            //try
            //{
            //    FixedSizeList.Get(0);
            //    FixedSizeList.Get(1);
            //    FixedSizeList.Get(10);
            //    FixedSizeList.Get(-5);
            //}
            //catch
            //{
            //    Console.WriteLine("Invalid index");
            //}



            #endregion
            #region Q4:Given a string, find the first non-repeated character in it and return its index. If there is no such character, return -1. Hint you can use dictionary
            //string Name = "NouraandNourandRadwaAndSalma";
            //Console.WriteLine(FirstNonRepeatedChar(Name));
            #endregion
        }
    }
}
