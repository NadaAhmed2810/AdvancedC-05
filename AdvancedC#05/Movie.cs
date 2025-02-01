using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvancedC_05
{
    class MovieComparer : IComparer<Movie>
    {
        public int Compare(Movie? x, Movie? y)
        {
           return x?.Title?.CompareTo(y?.Title??" ")??(y is null?0:-1);
        }
    }
    internal class Movie:IEquatable<Movie>, IComparable<Movie>
    {
        public int Code { get; set; }
        public string? Title { get; set; }
        public decimal Price { get; set; }

        public int CompareTo(Movie? other)
        {
            if (other == null) return 1;
            return Code.CompareTo(other.Code);
        }

        public bool Equals(Movie? other)
        {
           return other!=null && Code == other.Code && Title == other.Title && Price == other.Price;
        }
        public override int GetHashCode()
        {
            return HashCode.Combine(Code, Title, Price);
        }
        public override string ToString()=>$"Code:{Code},Title: {Title},Price:{Price}";
        

    }
}
