using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace geomatric
{
    class Shapes
    {
        public int id;
        public virtual double area()
        {
            return 0;
        }
    }

    class circle : Shapes
    {
        public double dia;
        public circle(double dia)
        {
            this.dia = dia;
        }

        public override double area()
        {
            return Math.PI * Math.Pow(dia / 2, 2);
        }
    }

    class rectangle : Shapes
    {
        public double width;
        public double height;
        public rectangle(double width, double height)
        {
            this.width = width;
            this.height = height;
        }
        public override double area()
        {
            return height * width;
        }
    }

    class cube : Shapes
    {
        public double height;
        public double width;
        public double depth;
        public cube(double height,double width,double depth)
        {
            this.height = height;
            this.width = width;
            this.depth = depth;
        }
        public override double area()
        {
            return 2 * (height * width + width * depth + depth * height);
        }
    }


}
