using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lazy
{
    class Program
    {
        static void Main(string[] args)
        {
            var tclazy = new MyLazy<TestClass>(() => new TestClass());
            var tc = tclazy.GetValue();
            Console.WriteLine(tc.Name);
            Console.WriteLine("end a program");
            Console.ReadLine();
        }
    }

    public class TestClass
    {
        public TestClass()
        {
            Name = "vasya";
        }

        public string Name { get; set; }
    }
    public class MyLazy<T>
    {
        private Func<T> _initFunc;
        private bool _created = false;
        protected T _value;

        public MyLazy(Func<T> func)
        {
            _initFunc = func;
        }

        public T GetValue()
        {
            if (!_created)
            {
                _value = _initFunc();
            }

            return _value;
        }
    }

    
}
