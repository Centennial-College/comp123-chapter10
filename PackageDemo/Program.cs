using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PackageDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Package p = new Package(23, "Tom", 23.11);
            Package p2 = new Package(3, "Tommy", 32);
            Package p3 = new Package(5, "Jake", 35);

            InsuredPackage ip = new InsuredPackage(6, "Lucas", 32, 20);
            InsuredPackage ip2 = new InsuredPackage(7, "Luke", 32, 20000);

            Console.WriteLine(p);
            Console.WriteLine(p2);
            Console.WriteLine(p3);

            Console.WriteLine(ip);
            Console.WriteLine(ip2);
        }
    }
}
