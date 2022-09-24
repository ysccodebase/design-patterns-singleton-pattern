using System;

namespace DesignPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Logger obj1 = Logger.GetLogger();
            Logger Obj2 = Logger.GetLogger();

            Console.WriteLine("This is the hashcode for obj1 = " + obj1.GetHashCode());
            Console.WriteLine("This is the hashcode for obj2 = " + Obj2.GetHashCode());
        }
    }

    //Example of singleton
    public class Logger
    {
        private static Logger instance;

        public static Logger GetLogger()
        {
            if(instance==null)
            {
                instance = new Logger();
            }
            return instance;
        }
    }
}
