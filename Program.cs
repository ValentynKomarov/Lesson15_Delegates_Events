using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson15_Delegates_Events
{
    public delegate void MyDelegate();
    
    class Program
    {
        public delegate int ValueDelegate(int i);
                
        static void Main(string[] args)
        {
            MyDelegate myDelegate = Method1;
            myDelegate += Method4;
            myDelegate();

            MyDelegate myDelegate2 = new MyDelegate(Method4);
            myDelegate2 += Method4;
            myDelegate2 -= Method4;
            myDelegate2.Invoke();

            MyDelegate myDelegate3 = myDelegate + myDelegate2;
            myDelegate3.Invoke();

            var valuedelegate = new ValueDelegate(MethodValue);
            valuedelegate += MethodValue;
            valuedelegate += MethodValue;
            valuedelegate += MethodValue;
            valuedelegate += MethodValue;

            valuedelegate(new Random().Next(10, 50));

            Action action = Method1;
            action();

            Predicate<int> predicate;

            Func<string, int> func;

            Console.ReadLine();
        }

        public static int MethodValue(int i)
        {
            Console.WriteLine(i);
            return i;
        }

        public static void Method1() 
        {
            Console.WriteLine("Method1");
        }

        public static int Method2()
        {
            Console.WriteLine("Method2");
            return 0;
        }

        public static void Method3(int i)
        {
            Console.WriteLine("Method3");
        }

        public static void Method4()
        {
            Console.WriteLine("Method4");
        }


    }
}
