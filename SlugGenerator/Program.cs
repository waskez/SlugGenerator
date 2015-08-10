using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace SlugGenerator
{
    class Program
    {
        static void Main(string[] args)
        {
            //var s = Console.ReadLine();
            var s = "оборудованием и облачная инфраструктура";
            Console.WriteLine(s.GenerateSlugFromRus());
            Console.ReadKey();
        }
    }
}
