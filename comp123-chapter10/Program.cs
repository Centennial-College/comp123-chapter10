using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace comp123_chapter10
{
    class Program
    {
        static void Main(string[] args)
        {
            Letter l = new Letter("Tom", DateTime.Now.ToString());
            CertifiedLetter cl = new CertifiedLetter("Billy", "July 14, 1988", 23433434);

            Console.WriteLine(l);
            Console.WriteLine();
            Console.WriteLine(cl);
        }
    }
}
