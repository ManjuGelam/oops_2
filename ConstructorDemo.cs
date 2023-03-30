using System;
using System.Collections.Generic;
using System.Text;

namespace oops_project
{
    class ConstructorDemo
    {
        public ConstructorDemo()//explicit constructor
        {
            Console.WriteLine("constructor is called");
        }
        public void Demo()
        {
            Console.WriteLine("method is called");
        }
      public  static void Main()
        {
            ConstructorDemo cd1 = new ConstructorDemo();
            
            ConstructorDemo cd2 = new ConstructorDemo ();
           
            ConstructorDemo cd3 = new ConstructorDemo();
            cd3 = cd2;
            cd1.Demo();
            Console.ReadLine();
        }
    }
}
    

