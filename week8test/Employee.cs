using System;
using System.Collections.Generic;
using System.Text;

namespace week8test
{
    class Employee
    {
        public string Name { get; set; }
        public int id { get; set; }
        public Gender gender;
        public enum Gender
        {
            F, M, X
        };
        public override string ToString()
        {
            return Name + '\t' + id + '\t' + gender;
        }
    }
}
