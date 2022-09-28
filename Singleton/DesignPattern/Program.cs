using System;
using System.Threading.Tasks;

namespace DesignPattern
{
    class Program
    {
        static void Main(string[] args)
        {

            Parallel.Invoke(Method1, Method2, Method3);
            Logger obj1 = Logger.GetLogger();
            Logger Obj2 = Logger.GetLogger();
            Logger Obj3 = Logger.GetLogger();
            //Logger obj4 = new Logger();
            Logger Obj4 = Logger.GetLogger();

            
            Console.WriteLine("This is the hashcode for obj1 = " + obj1.GetHashCode());
            Console.WriteLine("This is the hashcode for obj2 = " + Obj2.GetHashCode());
            Console.WriteLine("This is the hashcode for obj3 = " + Obj3.GetHashCode());
            Console.WriteLine("This is the hashcode for obj4 = " + Obj4.GetHashCode());
            Method1();
            Method2();
            Method3();

            /*
            Logger.DerivedClass obj7 = new Logger.DerivedClass();
            obj7.LoggerMethod1("This is the method wriiten in Logger class");
            */



        }

       static void Method1()
        {
            Logger Obj5 = Logger.GetLogger();
            Console.WriteLine("This is the hashcode for obj5 = " + Obj5.GetHashCode());
        }

         static void Method2()
        {
            Logger Obj6 = Logger.GetLogger();
            Console.WriteLine("This is the hashcode for obj6 = " + Obj6.GetHashCode());
        }

        static void Method3()
        {
            Logger Obj7 = Logger.GetLogger();
            Console.WriteLine("This is the hashcode for obj7 = " + Obj7.GetHashCode());
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


    //Example of singleton class with private constructor and marked as sealed
    /*
    public sealed class Logger
    {
        private static int counter = 0;
        
        private Logger()
        {
            counter++;
            Console.WriteLine("This is counter value: " + counter);
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

        public void LoggerMethod1(string msg)
        {
            Console.WriteLine("msg");
        }

        //
        //public class DerivedClass : Logger
        //{

        //}

        //
    }
      */

    //Singleton design pattern
    public sealed class Logger
    {
        private static int counter = 0;

        private Logger()
        {
            counter++;
            Console.WriteLine("This is counter value: " + counter);
        }

        private static Logger instance;

        private static readonly object lockobject = new object();

        
        public static Logger GetLogger()
        {
            if(instance == null)
            {
                lock (lockobject)
                {

                    if (instance == null)
                    {
                        instance = new Logger();
                    }

                }

            }

            return instance;
        }

        public void LoggerMethod1(string msg)
        {
            Console.WriteLine(msg);
        }
    }


}
