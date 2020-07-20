using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            // The code provided will print ‘Hello World’ to the console.
            // Press Ctrl+F5 (or go to Debug > Start Without Debugging) to run your app.
            dynamic x = 10;
            Program obj = new Program();
            obj.add();
            //Console.WriteLine("Hello World!");
            Console.ReadKey();

            // Go to http://aka.ms/dotnet-get-started-console to continue learning how to build a console app! 
        }

        int add(dynamic x=null,dynamic y=null)
        {
            Console.WriteLine("{0}|{1} ",x,"Hello");
            return 1;
        }

        int add(dynamic d)
        {
            Console.WriteLine("Inside dynamic overload");
            return 1;
        }

        int add(int d)
        {
            Console.WriteLine("Inside int overload");
            return 0;
        }
    }
}
