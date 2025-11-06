using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14._4
{
    abstract class Shape
    {
        public abstract string Draw();
    }
    class Circle: Shape
    {
        public override string Draw()
        {
            return "Рисую круг";
        }
    }
    class Triangle: Shape
    {
        public override string Draw()
        {
            return "Рисую треугольник";
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Shape[] sh = { new Circle(), new Triangle() };
            foreach (var s in sh)
            {
                Console.WriteLine(s.Draw());
            }
        }
    }
}
