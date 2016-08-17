using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapesDemo
{
    class Rectangle : GeometricFigure
    {
        public Rectangle(int w, int h) : base(w, h)
        {
        }

        public override void ComputeArea()
        {
            this._area = this.Width * this.Height;
        }
    }
}
