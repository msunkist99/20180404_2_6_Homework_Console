using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20180404_2_6_Homework_Console.People
{
    // the Student class inherits from the Person base class
    class Student : Person
    {
        public int Grade { get; set; }
        public double GPA { get; set; }
        public FirstNames FirstNamesEnum { get; set; }
    }

    public enum FirstNames
    {
        NoName = 0,
        Abby,
        Alex,
        Lauren,
        Drew,
        Sara,
        Cameron,
        Lindsey,
        Ashley,
        Jaden,
        Danielle
    }
}
