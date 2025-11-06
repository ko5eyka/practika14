using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14._3
{
    class Food
    {
        public virtual void Eat()
        {
            Console.WriteLine("Едим...");
        }
    }
    class Pizza: Food
    {
        public override void Eat()
        {
            Console.WriteLine("Едим пиццу!");
        }
    }
    class Burger : Food
    {
        public override void Eat()
        {
            Console.WriteLine("Едим бургер!");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Food[] fo = { new Pizza(), new Burger(), new Food() };
            foreach (var f in fo)
            {
                f.Eat();
            }
        }
    }
}
