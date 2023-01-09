using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _018_Data_object
{
    enum CHAR_STATE
    {
        IDLE,
        WALK,
        RUN,
        DIE
    }
    enum CLICK_STATE
    {
        NONE,
        CLICK = 100,
        DOUBLE_CLICK = 200,
        UP,
    }
    class Program
    {
        static void Main(string[] args)
        {
            CHAR_STATE charState = CHAR_STATE.IDLE;
            Console.WriteLine("{0} {1}",charState, (int)charState);

            
            bool? isFlag = null;

            Console.WriteLine(isFlag.HasValue);

        }
    }
}
