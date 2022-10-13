using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleHerentzia
{   
    internal class A
    {
        public string Prop1 { get; set; }
        public virtual string Prop2 { get; set; }

        public virtual void Erakutsi()
        {
            Console.WriteLine("A klasea");
            Console.WriteLine("{0}, {1}", Prop1, Prop2);
        }
    }
}
