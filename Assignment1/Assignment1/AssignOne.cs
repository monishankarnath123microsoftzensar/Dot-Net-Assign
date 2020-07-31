using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    abstract class Quadrilateral
    {
        public int length;
        public Quadrilateral(int _length)
        {
            length = _length;
        }
        public abstract double Area();
    }

    class Square : Quadrilateral
    {
        public Square(int _length):base(_length)
        {
                
        }
        public override double Area()
        {
            return length* length;
        }
    }

    class Rectangle : Quadrilateral
    {
        int breadth;
        
        public int IsSquare
        {
           get { return breadth; }
          set { 
            if(value == length)
                {

                    Console.WriteLine("True");
                    
                }
            else{
                    breadth = value;
                }
                    }
        }

        public Rectangle(int _length, int _breadth):base(_length)
        {
            breadth = _breadth;

                
        }
        public override double Area()
        {
            return length * breadth;
            
        }
    }
    class AssignOne
    {
        static void Main(string[] args)
        {
            Quadrilateral sq = new Square(4);
            Quadrilateral re = new Rectangle(6, 6);
            Console.WriteLine("Area SQ {0}",sq.Area());
            Console.WriteLine("Area RE {0}", re.Area());
           
            if(sq.Area() > re.Area())
            {
               Console.WriteLine("Square area is greater than Rectangle area");
            }
            else
            {
                Console.WriteLine("Square area is smaller than Rectangle area");
            }
        }
    }
}
