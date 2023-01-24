using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatGptDesignPatterns
{
    internal class Prototype
    {
    }
    interface IShape
    {
        IShape Clone();
        void Draw();
    }

    class Circle : IShape
    {
        public int X { get; set; }
        public int Y { get; set; }
        public int Radius { get; set; }

        public Circle(int x, int y, int radius)
        {
            X = x;
            Y = y;
            Radius = radius;
        }

        public IShape Clone()
        {
            return new Circle(X, Y, Radius);
        }

        public void Draw()
        {
            Console.WriteLine("Drawing Circle at X: {0}, Y: {1}, Radius: {2}", X, Y, Radius);
        }
    }
    class Rectangle : IShape
    {
        public int Width { get; set; }
        public int Height { get; set; }

        public Rectangle(int width, int height)
        {
            Width = width;
            Height = height;
        }

        public IShape Clone()
        {
            return new Rectangle(Width, Height);
        }

        public void Draw()
        {
            Console.WriteLine("Drawing Rectangle with Width: {0}, Height: {1}", Width, Height);
        }
    }
}
