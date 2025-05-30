using System;
namespace Singleton
{
    public class Singleton
    {
        private static Singleton instance= new Singleton();
        private  Singleton(){}
        public static Singleton AccessSingleton()
        {
        
            return instance;
        }
    }
    public class ExecuteSingleton
    {
        public static void Main(String[] args)
        {
            Singleton es =  Singleton.AccessSingleton();
            Singleton s = Singleton.AccessSingleton();
            Console.WriteLine("Singleton instance hash code: " + s.GetHashCode());

            
            Singleton s2 = Singleton.AccessSingleton();
            Console.WriteLine("Second access hash code: " + s2.GetHashCode());

            Console.WriteLine("Are both instances the same? " + (s == s2));
        }

     }
}





