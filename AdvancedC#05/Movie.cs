using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvancedC_05
{
    internal class Movie:IEquatable<Movie>
    {
        public int Code { get; set; }
        public string? Title { get; set; }
        public decimal Price { get; set; }

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
