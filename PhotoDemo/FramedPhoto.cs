using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhotoDemo
{
    class FramedPhoto: Photo
    {
        public string Material { get; set; }
        public string Style { get; set; }

        public FramedPhoto(int width,int height,string material, string style): base(width, height)
        {
            this.Material = material;
            this.Style = style;
        }

        protected override void calculatePrice()
        {
            base.calculatePrice();
            this.price += 25;
        }

        public override string ToString()
        {
            return base.ToString() + string.Format("Material: {0}\nStyle: {1}\n",
                this.Material, this.Style);
        }
    }
}
