using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Length len1 = new Length(2, 8);
            Length len2 = new Length(4, 5);
            Length len3 = len1 + len2;
            Console.WriteLine(len1.getLength());
            Console.WriteLine(len2.getLength());
            Console.WriteLine(len3.getLength());
            Console.ReadKey();
        }
    }
}
