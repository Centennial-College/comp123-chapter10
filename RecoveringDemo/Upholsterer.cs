using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecoveringDemo
{
    class Upholsterer:IRecoverable
    {
        public void Recover()
        {
            Console.WriteLine("I am upholsterer and getting better");
        }
    }
}
