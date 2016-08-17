using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapesDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Rectangle r = new Rectangle(10, 20);
            Square s = new Square(10, 10);
            Square s2 = new Square(20);
            Triangle t = new Triangle(100, 50);

            GeometricFigure[] gfs = new GeometricFigure[] { r, s, s2, t };

            foreach (GeometricFigure gf in gfs)
            {
                DisplayShapeData(gf);
            }
        }

        private static void DisplayShapeData(GeometricFigure gf)
        {
            Console.WriteLine("Shape: {0}\nWidth: {1} cm\nHeight: {2} cm\nArea: {3} cm^2\n",
                gf.GetType().ToString().Substring(gf.GetType().ToString().IndexOf(".") + 1),
                gf.Width, gf.Height, gf.Area);
        }
    }
}
