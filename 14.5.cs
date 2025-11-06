using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14._5
{
    class Player
    {
        public virtual void Attack()
        {
            Console.WriteLine("Атакую!");
        }
    }
    class Warrior: Player
    {
        public override void Attack()
        {
            Console.WriteLine("Рублю мечом!");
        }
    }
    class Archer: Player
    {
        public override void Attack()
        {
            Console.WriteLine("Стреляю из лука!");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Player[] pl = { new Warrior(), new Archer(), new Player() };
            foreach (var p in pl)
            {
                p.Attack();
            }
        }
    }
}
