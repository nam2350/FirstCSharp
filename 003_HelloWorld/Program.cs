using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _003_HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("지금 듣는 강의는 {0} {1} 좋아요!!!", args[0], args[1]);
        }
        //static int Main(string[] args)
        //{
        //    Console.WriteLine("AAA{0} BBB{1}", 1, "ggg");
        //    Console.WriteLine("1{0} 2{1} 3{2}", 1, 2,3);
        //    return 0;
        //}
    }
}
