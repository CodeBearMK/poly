using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace poly
{
    internal class Animal
    {
        public virtual void display()
        {
            Console.WriteLine("現在是執行  父類別  Animal");
        }
    }
}
