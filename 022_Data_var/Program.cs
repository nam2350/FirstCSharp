using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _022_Data_var
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = 100;
            var b = 3.14f;
            var c = 3.1453463m;
            var d = 'A';
            var e = "hello";
            var f = false;


            Console.WriteLine("type : {0}, value : {1}",a.GetType(), a);
            Console.WriteLine("type : {0}, value : {1}",b.GetType(), b);
            Console.WriteLine("type : {0}, value : {1}",c.GetType(), c);
            Console.WriteLine("type : {0}, value : {1}",d.GetType(), d);
            Console.WriteLine("type : {0}, value : {1}",e.GetType(), e);
            Console.WriteLine("type : {0}, value : {1}",f.GetType(), f);
        }
    }
}
