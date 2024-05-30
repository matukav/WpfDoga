using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    public class People
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public int Age { get; set; }
        public string? City { get; set; }
        public string? Job { get; set; }
        public string? Wage { get; set; }

        public People() { }
        public People(string sor)
        {
            var a = sor.Split(";");
            Name = a[0];
            Age = Convert.ToInt32(a[1]);
            City = a[2];
            Job = a[3];
            Wage = a[4];
        }

        public override string? ToString()
        {
            return $"Név: {Name}, Életkor: {Age}, Város: {City}, Foglalkozás: {Job}, Bevétel: {Wage}";
        }
    }
}
