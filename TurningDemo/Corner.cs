using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TurningDemo
{
    public class Corner : ITurnable
    {
        public void Turn()
        {
            Console.WriteLine("You turn the corner and see new hope.");
        }
    }
}