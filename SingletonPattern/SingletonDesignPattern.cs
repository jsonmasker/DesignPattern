using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonPattern
{
    public sealed class SingletonDesignPattern
    {
        private static SingletonDesignPattern instance = null;
        private static readonly object padlock = new object();
        private SingletonDesignPattern()
        {
        }
        public static SingletonDesignPattern Instance
        {
            get
            {
                lock (padlock)
                {
                    if (instance == null)
                    {
                        instance = new SingletonDesignPattern();
                    }
                    return instance;
                }
            }
        }
        public void Print(ConsoleColor color, int x)
        {
            for (int i = 0; i < x; i++)
            {
                Console.ForegroundColor = color;
                Console.WriteLine("Hello world");
            }
        }
    }
}
