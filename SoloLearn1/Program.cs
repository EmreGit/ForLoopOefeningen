using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoloLearn1
{
    class Program
    {
        static void Main(string[] args)
        {
            string name;
            int age;

            Console.WriteLine("Type in your name");
            name = Console.ReadLine();
            
            Console.WriteLine("Type in your age");
            age = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(name);
            Console.WriteLine(age);
        }
    }
}
