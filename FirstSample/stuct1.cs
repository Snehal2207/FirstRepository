using System;
namespace FirstSample
{
    public class name
    {
        int _Display = 10;
        /*public int getDisplay()
        {
            return i;
        }
        public void setDisplay(int y)
        {
            i = y;
        }*/
        public int Display
        {
            get { return _Display; }
            set 
            { 
                if (value > _Display) 
                { _Display = value; } 
            }
        }
     }
    class name1
    {
        
        static void Main()
        {
            name n1 = new name();
            
            Console.WriteLine(n1.Display);
            
            n1.Display=2;
            int y = n1.Display;
            Console.WriteLine(y);
           
        }
    }
    
}