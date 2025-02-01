using System;
using System.Collections;
using System.Diagnostics.CodeAnalysis;

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
    class StringEqualityComparer : IEqualityComparer<string>
    {
       

        public bool Equals(string? x, string? y)
        {
           
            return x?.ToLower().Equals(y?.ToLower()) ?? (y is null ? true : false);
        }

    
        public int GetHashCode([DisallowNull] string obj)
        {
       
            return obj.ToLower().GetHashCode();
        }
    }
    class StringDecsComparer : IComparer<string>
    {
        public int Compare(string? x, string? y)
        {
           return y?.CompareTo(x)??(x is null?0:-1);
        }
    }
    class EmployeeEqualityComparer : IEqualityComparer<Employee>
    {
        public bool Equals(Employee? x, Employee? y)
        {
            return x?.Id.Equals(y?.Id??0)?? (y is null ? true : false) ;
        }

        public int GetHashCode([DisallowNull] Employee obj)
        {
           return obj.Id.GetHashCode();
        }
    }

    class EmployeeComparer : IComparer<Employee>
    {
        public int Compare(Employee? x, Employee? y)
        {
           return x?.Name?.CompareTo(y?.Name??string.Empty)?? (y is null?0:-1);
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
            #region Generic Collection "Dictionary"
            #region Constructor
            //Dictionary<string, int> Note = new Dictionary<string, int>()
            //{
            //  ["Ahmed"] =111,
            //  ["Nadia"]=222,
            //  ["Nour"]=333, 
            //};
            //Dictionary<string, int> Note02 = new Dictionary<string, int>(Note,new StringEqualityComparer());
            //KeyValuePair<string, int>[] keyValuePairs = new KeyValuePair<string, int>[3]
            //{
            //    new KeyValuePair<string, int>("Ahmed",111),
            //    new KeyValuePair<string, int>("Nada",222),
            //    new KeyValuePair<string, int>("Nour",333)
            //};
            //Dictionary<string, int> Note03 = new Dictionary<string, int>(keyValuePairs);

            #endregion

            #region Add And Set and get 
            ///ADD
            ///Note.Add("Girgis", 888);//not safe 
            ///if (!Note.ContainsKey("Girgis"))
            ///    Note.Add("Girgis", 888);
            ///Note.TryAdd("Girgis", 888);//will return bool 

            ///Get 
            ///Console.WriteLine($"{Note["Ahmed"]}");
            ///un safe Code
            ///Console.WriteLine($"{Note["Nada"]}");//will Throw Exception 
            ///Note.TryGetValue("Nada", out int Value); //return bool
            ///Console.WriteLine(Value);//return default if not exists 

            ///Set 
            ///Note["Yasmine"] = 444; //Toggle

            #endregion

            #region Example01 "Key must be Immutable"
            //Employee employee01 = new Employee(10, "Nada", 10000);
            //Employee employee02 = new Employee(20, "Nour", 20000);
            //Employee employee03 = new Employee(30, "Noura", 30000);
            //Dictionary<Employee, string> employees = new Dictionary<Employee, string>(new EmployeeComparer())
            //{
            //    [employee01]=employee01.ToString(),
            //    [employee02]=employee02.ToString(),
            //    [employee03]=employee03.ToString(),
            //};

            //employee01.Id = 90;
            //employees.Add(new Employee() { Id = 90 }, string.Empty);
            //employees.Add(new Employee(40, "Radwa", 40000), "Id :40,Name: Radwa,Salary: 40000");
            //foreach (var employee in employees)
            //{
            //    Console.WriteLine($"Employee: {employee.Key}");
            //} 
            //employees.Add(new Employee(10, "Nada", 10000), "Nada");
            //employees.Add(new Employee(){Id =20}," ");
            #endregion


            #region Looping 
            //foreach (var Person in Note)
            //{
            //    Console.WriteLine($"Name:{Person.Key}:::Number:{Person.Value}");
            //}
            //Console.WriteLine();
            //foreach (var key in Note.Keys)
            //{
            //    Console.WriteLine(key);
            //}
            //Console.WriteLine();
            //foreach (var value in Note.Values)
            //{
            //    Console.WriteLine(value);
            //} 
            #endregion
            #endregion
            #region Generic Collection Sorted Dictionary [Binary search tree]
            #region Example01
            //SortedDictionary<string, int> SortedNote = new SortedDictionary<string, int>(new StringDecsComparer())
            //{
            //    ["Ahmed"] = 111,
            //    ["Nour"]=222,
            //    ["Radwa"]=333,
            //    ["Basma"]=444
            //};
            //foreach (var Person in SortedNote)
            //{
            //     Console.WriteLine($"Name:{Person.Key}:::Number:{Person.Value}");
            //} 
            #endregion
            #region Example02
            //Employee employee01 = new Employee(10, "Nada", 10000);
            //Employee employee02 = new Employee(200, "Nour", 20000);
            //Employee employee03 = new Employee(30, "Noura", 30000);
            //SortedDictionary<Employee,string > Employees= new SortedDictionary<Employee, string>(new EmployeeComparer())
            //{
            //    [employee01] = employee01.ToString(),
            //    [employee02] = employee02.ToString(),
            //    [employee03] = employee03.ToString(),
            //};

            //foreach(var employee in Employees)
            //{
            //    Console.WriteLine($"Name:{employee.Key}:::Number:{employee.Value}");
            //} 
            #endregion

            #endregion
            #region Generic Collection "Sorted List" [Two Arrays]
            //SortedList<string,int> SortedList = new SortedList<string, int>()
            //{
            //    ["Ahmed"] = 111,
            //    ["Nour"] = 222,
            //    ["Radwa"] = 333,
            //    ["Basma"] = 444
            //};
            //Console.WriteLine($"GetKeyAtIndex(0):{SortedList.GetKeyAtIndex(0)}");
            //Console.WriteLine($"GetValueAtIndex(0):{SortedList.GetValueAtIndex(0)}");
            //foreach(var Person in SortedList)
            //{
            //    Console.WriteLine($"Name:{Person.Key}:::Number:{Person.Value}");
            //}
            #endregion
            #region Generic Collection Hashset 
            //HashSet<int>Numbers= new HashSet<int>()
            //{
            //    8,10,5,4,8,1,10,3,7,3
            //};
            //foreach (var Num in Numbers)
            //{
            //    Console.WriteLine(Num);
            //}

            //Employee employee01 = new Employee(10, "Nada", 10000);
            //Employee employee02 = new Employee(20, "Nour", 20000);
            //Employee employee03 = new Employee(30, "Noura", 30000);
            //HashSet<Employee> set = new HashSet<Employee>()
            //{
            //    new Employee(10, "Nada", 10000),
            //    new Employee(20, "Nour", 20000),
            //    new Employee(30, "Noura", 30000),
            //    new Employee(30, "Noura", 30000),
            //    new Employee(20, "Nour", 20000)
            //};
            //foreach (Employee employee in set)
            //{
            //    Console.WriteLine(employee);
            //}

            //HashSet<Movie> movies = new HashSet<Movie>()
            //{
            //    new Movie(){Code =10,Title="Titanic" ,Price=100},
            //    new Movie(){Code =20,Title="Black Adam" ,Price=200},
            //    new Movie(){Code=30,Title="Another One" ,Price=300},
            //    new Movie(){Code=30,Title="Another One" ,Price=300},
            //    new Movie(){Code=30,Title="Another One" ,Price=300}
            //};
            //foreach (Movie movie in movies)
            //{
            //    Console.WriteLine(movie);
            //}
                    
            #endregion
        }
    }
}
