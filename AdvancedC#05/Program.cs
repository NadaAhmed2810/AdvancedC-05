using System.Collections;

namespace AdvancedC_05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Non_Generic_Collection"HashSet"
            Hashtable Note = new Hashtable()
            {
                ["Nada"] = 111,
                ["Noura"] = 222,
                ["Nour"] = 333,
            };
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
