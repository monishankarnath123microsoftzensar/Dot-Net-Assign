using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAnimal
{
    interface IVolume
    {
        double Volume { get; }

    }
    interface IArea
    {
        double SurfaceArea();
    }
    interface ISolid : IArea, IVolume
    {

    }

    abstract class Solid : ISolid
    {
        public double radius;
        public const double pi = 3.142;
        public abstract double Volume
        {
            get;
        }

        public abstract double SurfaceArea();
        public Solid(double rad)
        {
            radius = rad;
        }
        public double Radius
        {
            get { return radius; }
            set { radius = value; }
        }
    }
    class Cylinder : Solid
    {
        double height;
        double volume;
        //public override double Volume { get; }

        public Cylinder(double _height, double radius) : base(radius)
        {
            height = _height;
        }
        public double Height
        {
            get { return height; }
            set { height = value; }
        }
        public override double Volume
        {
            get
            {
                Console.Write("Volume of Cylinder is: ");
                return pi * radius * radius * height;
            }
        }

        public override double SurfaceArea()
        {
            Console.Write("Area of Cylinder is: ");
            var sa = 2 * pi * radius * (radius + height);
            return sa;
        }
    }

    class Sphere : Solid
    {
        public Sphere(double radius) : base(radius)
        {

        }
        public override double SurfaceArea()
        {
            Console.Write("Area of Sphere is: ");
            var sa = (4 / 3) * pi * radius * radius * radius;
            return sa;
        }
        public override double Volume
        {
            get
            {
                Console.Write("Volume of Sphere is: ");
                return 4 * pi * radius * radius;
            }
        }
        class InterfaceAssign
        {
            static void Main(string[] args)
            {
                Cylinder obj = new Cylinder(10, 12);
                Sphere obj1 = new Sphere(6);
                Console.WriteLine(obj.SurfaceArea());
                Console.WriteLine(obj.Volume);
                Console.WriteLine("---------------------------------------");
                Console.WriteLine(obj1.SurfaceArea());
                Console.WriteLine(obj1.Volume);
                Console.WriteLine("---------------------------------------");

            }
        }
    }
}

