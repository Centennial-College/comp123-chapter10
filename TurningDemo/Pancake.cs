using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TurningDemo
{
    public class Pancake : ITurnable
    {
        public void Turn()
        {
            Console.WriteLine("You turn the pancake and apply the maple syurp.");
        }
    }
}