using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForOefening8
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int y = 1; y < 10; y++)
            {
                for (int x = 1; x < 10; x++)
                {
                    Console.Write("{0} ", x * y);

                    //Don't forget dollar sign when you need
                    //it and also write value from "for" in the writeline like this !
                }
                Console.WriteLine();
            }
        }
    }
}
