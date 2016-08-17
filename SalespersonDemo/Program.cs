using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalespersonDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            RealEstateSalesperson res = new RealEstateSalesperson("Kevin", "Ma", 0.99f);
            GirlScout gs = new GirlScout("Sarina", "Luu");

            Console.WriteLine(res);
            Console.WriteLine(gs);

            res.MakeSale(1000000);
            gs.MakeSale(8);
            Console.WriteLine();

            Console.WriteLine(res);
            Console.WriteLine(gs);

            res.MakeSale(2324213);
            gs.MakeSale(2);
            Console.WriteLine();

            Console.WriteLine(res);
            Console.WriteLine(gs);
        
        }
    }
}
