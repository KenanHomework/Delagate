using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delagate
{
    /* Func delagate declaration */
    public delegate void Func(string str);

    class MyClass
    {
        public void Space(string str)
        {
            StringBuilder sb = new StringBuilder();
            foreach (char item in str)
            {
                sb.Append(item);
                sb.Append('_');
            }
            Console.WriteLine($"Space: {sb}");
        }

        public void Reverse(string str)
        {
            StringBuilder stringBuilder = new StringBuilder();
            foreach (char item in str)
            {
                if (item != '_') stringBuilder.Append(item);
            }
            Console.WriteLine($"Reverse: {stringBuilder}");
        }

    }

    class Run
    {
        public void runFunc(Func func, string str)
        {
            func.Invoke(str);
        }

    }

    public class Program
    {



        static void Main(string[] args)
        {
            Console.WriteLine("Enter string");
            string str = Console.ReadLine();
            MyClass cls = new MyClass();
            Func funcDell = new Func(cls.Space);
            funcDell += cls.Reverse;
            Run run = new Run();
            run.runFunc(funcDell, str);
        }
    }

}

