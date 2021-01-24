using System;
using System.Collections.Generic;

namespace Dictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, string> student = new Dictionary<int, string>();
            student.Add(1,"Ahmet");
            student.Add(2,"Mehmet");
            student.Add(3,"Engin");
            student.Add(4,"Mustafa");
        }
    }
}
