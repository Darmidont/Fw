using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fw_st
{
    class Program
    {
        static void Main(string[] args)
        {
           // Singleton s = Singleton.Instance;
            Console.WriteLine("end a program");
            Console.ReadLine();
        }
    }

    public class Singleton
    {
        private Singleton() { }

        public static Singleton Instance
        {
            get
            {
                return SingleToneOnstance._instance;
                
            }
        }

        private class SingleToneOnstance
        {
            internal static Singleton _instance = new Singleton();
        }
    }
}
