using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inher
{
    class Program
    {
        static void Main(string[] args)
        {
            //A a = new D();
            //a.Print();

            //B b = (D) a;
            //b.Print();

            //D d = new D();
            //d.Print();
            ////C c = d;
            ////c.Print();
            //B b1 = new E();
            //b1.Print();

            D d = new D();
            //d.Print();

            ((IPrint) d).Print();

            Console.WriteLine("end a program");
            Console.ReadLine();
        }
    }

    public interface IPrint
    {
        void Print();
    }

    public abstract class A: IPrint
    {
        public abstract void Print();
    }

    public class B :A
    {
        public override void Print()
        {
            Console.WriteLine("A print");
        }
    }

    public class C : B
    {
        public override void Print()
        {
            Console.WriteLine("C print");
        }
    }

    public class D : C, IPrint
    {
        public virtual new void Print()
        {
            Console.WriteLine("D print");
        }
    }

    public class E : D, IPrint
    {
        public override void Print()
        {
            Console.WriteLine("E print");
        }
    }
}
