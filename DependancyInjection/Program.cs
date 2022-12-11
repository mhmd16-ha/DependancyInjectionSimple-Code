using System;

namespace DependancyInjection
{
    class Mobile
    {
        int x;
        int y;
        public Mobile(int _x,int _y)
        {
            this.x = _x;
            this.y = _y;

        }
    }
    class Web
    {
      private  Mobile r;
        public Web(Mobile _r)
        {
            //Mobile m = new Mobile(10);//erro
            r = _r;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
