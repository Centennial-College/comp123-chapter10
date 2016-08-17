using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecoveringDemo
{
    class Patient:IRecoverable
    {
        public void Recover()
        {
            Console.WriteLine("Nurse is fixing me up and I am getting better.");
        }
    }
}
