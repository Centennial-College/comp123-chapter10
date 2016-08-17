using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecoveringDemo
{
    class FootballPlayer : IRecoverable
    {
        public void Recover()
        {
            Console.WriteLine("Cheerleader is giving me a hand and I am getting better.");
        }
    }
}
