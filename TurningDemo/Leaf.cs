using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TurningDemo
{
    public class Leaf : ITurnable
    {
        public void Turn()
        {
            Console.WriteLine("You turn the leaf over and start anew.");
        }
    }
}