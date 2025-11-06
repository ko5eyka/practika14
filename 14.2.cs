using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14._2
{
    class Message
    {
        public virtual void Send()
        {
            Console.WriteLine("Сообщение отправлено.");
        }
    }
    class Email: Message
    {
        public override void Send()
        {
            Console.WriteLine("Email отправлен!");
        }
    }
    class SMS : Message
    {
        public override void Send()
        {
            Console.WriteLine("SMS отправлено!");
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Message[] ms = { new Email(), new SMS(), new Message()};
            foreach (var m in ms)
            {
                m.Send();
            }
        }
    }
}
