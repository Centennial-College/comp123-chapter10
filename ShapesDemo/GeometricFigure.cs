using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapesDemo
{
    abstract class GeometricFigure
    {
        private float _width;
        private float _height;
        protected float _area;

        public float Width
        {
            get
            {
                return this._width;
            }
            set
            {
                this._width = value;
                this.ComputeArea();
            }
        }

        public float Height
        {
            get
            {
                return this._height;
            }
            set
            {
                this._height = value;
                this.ComputeArea();
            }
        }

        public float Area
        {
            get
            {
                return this._area;
            }
        }

        public GeometricFigure(float w, float h)
        {
            this.Width = w;
            this.Height = h;
        }

        public abstract void ComputeArea();
    }
}
