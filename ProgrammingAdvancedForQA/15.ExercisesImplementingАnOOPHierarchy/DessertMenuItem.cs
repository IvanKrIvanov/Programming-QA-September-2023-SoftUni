using ExerciseOopHierarchy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ExerciseOopHierarchy
{
    public class DessertMenuItem : MenuItem
    {
        public DessertMenuItem(string name, string description, decimal price) : base(name, description, price)
        {

        }
        public override string ToString()
        {
            return $"DessertMenuItem: {base.ToString()}";
        }
    }
}
