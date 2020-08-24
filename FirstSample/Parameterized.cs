using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FirstSample
{
    class Parameterized
    {
        int x;
        public Parameterized(int i)
        {
            x = i;
            Console.WriteLine("This is parameterrized :" + i);
        }
        public void Display()
        {
            Console.WriteLine("This is display method:"+x);
        }
        static void Main()
        {
            Parameterized pr1 = new Parameterized(10);
            pr1.Display();
            Console.ReadLine();
        }
    }
}
