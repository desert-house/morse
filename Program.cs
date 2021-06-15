using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace morse
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Select Languages 1 ToEnglish 2 ToMorse 3 ToRussian 4 FormRussianToMorse");
            var i = int.Parse(Console.ReadLine() ?? string.Empty);
            Morse.Translate(i);
        }
    }
}
