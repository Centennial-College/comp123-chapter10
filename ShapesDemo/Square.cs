using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapesDemo
{
    class Square : Rectangle
    {
        public Square(int w, int h) : base(w, w)
        {
        }

        public Square(int w) : this(w, w)
        {
        }
    }
}
