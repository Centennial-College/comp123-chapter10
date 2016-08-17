using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecoveringDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            FootballPlayer fp = new FootballPlayer();
            Patient p = new Patient();
            Upholsterer u = new Upholsterer();

            IRecoverable[] irs = new IRecoverable[] { fp, p, u };

            foreach (IRecoverable ir in irs)
            {
                UseRecover(ir);
            }
        }

        private static void UseRecover(IRecoverable ir)
        {
            ir.Recover();
        }
    }
}
