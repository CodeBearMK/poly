using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace poly
{
    internal class Person:Animal
    {
        public override void display()
        {
            Console.WriteLine("現在是執行  子類別  Person");
        }
    }
}
