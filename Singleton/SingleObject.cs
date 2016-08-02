using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    /// <summary>
    /// Eager initialization - the instance created when the clas loads
    /// </summary>
    public class SingleObject
    {

        //create an object of SingleObject
        private readonly static SingleObject instance = new SingleObject();

        //make the constructor private so that this class cannot be instantiated
        private SingleObject() {}

        //Get the only object available
        public static SingleObject getInstance
        {
            get { return instance; }
        }

        public void showMessage()
        {
            Console.WriteLine("Hello World!");
        }
    }

    /// <summary>
    /// for exeption handling
    /// </summary>
    public class StatickBlockSingleton
    {
        private static StatickBlockSingleton instance;

        private StatickBlockSingleton()
        {}

        static StatickBlockSingleton()
        {
            try
            {
                instance = new StatickBlockSingleton();
            }
            catch (Exception e)
            {

                throw e;
            }
        }

        public static StatickBlockSingleton getInstance()
        {
            return instance;
        }
    }

    /// <summary>
    /// initiliza when needed but nor thread safe
    /// </summary>
    public class LazyInintializationSingleton
    {
        private static LazyInintializationSingleton instance;

        private LazyInintializationSingleton()
        {

        }

        public static LazyInintializationSingleton getInstance()
        {
            if (instance == null)
                instance = new LazyInintializationSingleton();
            return instance;
        }
    }

    public class ThreadSafeSingleton
    {
        private static ThreadSafeSingleton instance;

        private ThreadSafeSingleton() { }

        public ThreadSafeSingleton getInstance()
        {
            lock (this)
            {
                if (instance == null)
                    instance = new ThreadSafeSingleton();
                return instance;
            }

        }
    }

    /// <summary>
    /// no need for Multi Threaded lock, the inner class is not inititilized up until the instance is needed
    /// </summary>
    public class BillPughSingleton
    {
        private BillPughSingleton(){}

        private static class SingletonHalper { internal static BillPughSingleton Instance = new BillPughSingleton(); }

        public static BillPughSingleton getInstance()
        {
            return SingletonHalper.Instance;
        }
    }
}
