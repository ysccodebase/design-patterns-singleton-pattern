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
            Logger Obj3 = Logger.GetLogger();
            //Logger obj4 = new Logger();
            Logger Obj4 = Logger.GetLogger();


            Console.WriteLine("This is the hashcode for obj1 = " + obj1.GetHashCode());
            Console.WriteLine("This is the hashcode for obj2 = " + Obj2.GetHashCode());
            Console.WriteLine("This is the hashcode for obj3 = " + Obj3.GetHashCode());
            Console.WriteLine("This is the hashcode for obj4 = " + Obj4.GetHashCode());
        }
    }

    /*
    //Example of singleton class without private constructor
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
    */


    //Example of singleton class with private constructor
    public class Logger
    {
        private Logger()
        {

        }

        private static Logger instance;

        public static Logger GetLogger()
        {
            if (instance == null)
            {
                instance = new Logger();
            }
            return instance;
        }
    }
}
