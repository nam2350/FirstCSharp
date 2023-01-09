using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _008_Data1
{
    class Program
    {
        static void Main(string[] args)
        {
            byte sbyteData = 255;
            sbyte sbyteDate2 = (sbyte)sbyteData;

            Console.WriteLine("sbyteData : " + sbyteData);
            Console.WriteLine("sbyteData2 : " + sbyteDate2);
            Console.WriteLine("sbyte.MaxValue : " + sbyte.MaxValue);
        }
    }
}
