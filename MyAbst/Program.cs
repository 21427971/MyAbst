using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Dynamic polymorphism in virtual function
namespace MyAbst
{
    class Shape
    {
        protected int width, height;
        public Shape(int w = 0, int h = 0)
        {
            width = w;
            height = h;
        }
        public virtual int area()
        {
          //  Console.WriteLine("Parent class area:");
            return 0;
        }
    class rectangle:Shape
        {
            public rectangle(int a=0,int b=0):base(a,b)
            {

            }
            public override int area()
            {
                Console.WriteLine("Enter a width");
                width = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter a width");
                height = int.Parse(Console.ReadLine());
                Console.Write("The area of a rectangle is :");
                return (width * height);

            }
          class CallArea//call the area method
            {
                static void Main(string []args)
                {

                    rectangle obj = new rectangle();
                    double c = obj.area();
                    Console.WriteLine(c);
                }
            }
        }
    }

}
