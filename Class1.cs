using System;

namespace ClassLibrary1
{

    interface IFigure
    {
        float Square();
    }
    public class Circle : IFigure
    {
        private float r;
        public Circle(float r)
        {
            if(r>0)
            {
                this.r = r;
            }
            else
            {
                this.r = 1;
                Console.WriteLine("Inputed circle is impossible, created unit circle(r=1)");
            }
        }
        public float Square()
        {
            return (float) Math.PI * r * r;
        }
    }
    public class Triangle
    {
        private float a, b, c;

        public Triangle(float a,float b,float c)
        {
            if (a >= 0 && b >= 0 && c >= 0 && a + b >= c && b + c >= a && c + a >= b)
            {
                this.a = a;
                this.b = b;
                this.c = c;
            }
            else
            {
                this.a = 5;
                this.b = 4;
                this.c = 3;
                Console.WriteLine("Inputed traingle is impossible, created Egyptian triangle (5,4,3)");
            }
        }

        public float Square()
        {
            float p = (a + b + c) / 2f;
            return (float)Math.Sqrt(p * (p - a) * (p - b) * (p - c));
        }
    }
}
