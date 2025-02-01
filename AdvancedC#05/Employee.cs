using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvancedC_05
{
    internal class Employee:IEquatable<Employee>
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public decimal Salary { get; set; }
       public  Employee() { }
        public Employee(int Id,string? Name,decimal Salary)
        {
            this.Id = Id;
            this.Name = Name;
            this.Salary = Salary;
        }

        public override string ToString()
        {
            return $"Id :{Id},Name: {Name},Salary: {Salary}";
        }

        public bool Equals(Employee? other)
        {
            return Id.Equals(other?.Id??0) &&( Name?.Equals(other?.Name??" ")??(other?.Name is null ?true:false)) && Salary.Equals(other?.Salary??0);
        }
        public override int GetHashCode()
        {
            return HashCode.Combine(Id,Salary,Name);
        }
    }
}
