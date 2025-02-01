using System.Collections;

namespace AdvancedC_05
{
    class StringHashCodeProvider : IHashCodeProvider
    {
        public int GetHashCode(object obj)
        {
            string? s = obj as string;
            if (s == null)
                throw new ArgumentNullException(nameof(obj));
            return s.ToLower().GetHashCode();
        }
    }
    class StringComparer : IComparer
    {
        public int Compare(object? x, object? y)
        {
            string? Strx = x as string;
            string? Stry = y as string;
            return Strx?.ToLower().CompareTo(Stry?.ToLower()) ?? (Stry is null ? 0 : -1);
        }

    }
    class StringEqualityComparer : IEqualityComparer
    {
        public new bool Equals(object? x, object? y)
        {
            string? Strx=x as string;
            string? Stry=y as string;
            return Strx?.ToLower().Equals(Stry?.ToLower())??(Stry is null?true:false);
        }

        public int GetHashCode(object obj)
        {
            string? s = obj as string;
            if (s == null)
                throw new ArgumentNullException(nameof(obj));
            return s.ToLower().GetHashCode() ;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Non_Generic_Collection"HashSet"
            // Hashtable Note = new Hashtable(10)
            // Hashtable Note = new Hashtable(10,.72F)
            //Hashtable Note = new Hashtable(10,.72f,new StringEqualityComparer())
            //Hashtable Note = new Hashtable(10, .72f, new StringHashCodeProvider(), new StringComparer());
            //Hashtable Note = new Hashtable()
            //{
            //    ["Nada"] = 111,
            //    ["Noura"] = 222,
            //    ["Nour"] = 333,
            //};
            //Note.Add("nada",333);
            //Hashtable Note02 = new Hashtable(Note);
            #region Set / Add / Get 
            ///Set 
            /// Note["Ahmed"] = 555;//will update if Ahmed exist and will add if not exist

            ///Add 
            ///unSafe Code 
            ///Note.Add("Nada", 555);//will Throw Exception
            ///if (!Note.Contains("Nada"))
            ///{
            ///    Note.Add("Nada",555);
            ///}

            ///Get
            /// Console.WriteLine(Note["Nada"});//111
            /// Console.WriteLine(Note["Ahmed]);//will return Null [Not Throw Exception] 
            #endregion

            #region Looping for HashTable
            ///UnValid
            ///for (int i = 0; i < Note.Count; i++)
            ///{
            ///    Console.WriteLine(Note[i]);
            ///}

            ///foreach (DictionaryEntry entry in Note)
            ///{
            ///    Console.WriteLine($"Name:{entry.Key}:::Number:{entry.Value}");
            ///}

            ///foreach (string key in Note.Keys)
            ///{
            ///    Console.WriteLine($"Name:{key}");
            ///}

            ///foreach (int Value in Note.Values)
            ///{
            ///    Console.WriteLine($"Number:{Value}");
            ///} 
            #endregion



            #endregion
        }
    }
}
