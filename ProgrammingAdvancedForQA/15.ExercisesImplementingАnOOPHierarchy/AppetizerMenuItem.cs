﻿using ExerciseOopHierarchy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ExerciseOopHierarchy
{
    public class AppetizerMenuItem : MenuItem
    {
        public AppetizerMenuItem(string name, string description, decimal price) : base(name, description, price)
        {

        }
        public override string ToString()
        {
            return $"Appetizer: {base.ToString()}";
        }
    }
}
