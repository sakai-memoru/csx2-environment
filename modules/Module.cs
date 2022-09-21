using System;

namespace Modules
{
    class Module
    {
        public void DoMain(string str)
        {
            Console.WriteLine($"Hello, {str} !!");
        }
    
    }
  
    class Calc
    {
        public static int Add(int x, int y) 
        {
            int ret = 0;
            ret = x + y;
            return ret;
        }

    }

}