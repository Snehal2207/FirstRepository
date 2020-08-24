using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FirstSample
{
    class DemoClass
    {
        public DemoClass() {
            Console.WriteLine("This is constroctor");
        }
        static void Main() {
            DemoClass dc1 = new DemoClass();
            DemoClass dc2 = new DemoClass();
            Console.ReadLine();
        }

    }
}
