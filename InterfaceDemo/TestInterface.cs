using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceDemo
{
    internal interface TestInterface
    {
        void Add(int a, int b);
    }

    internal interface TestInterface2 : TestInterface
    {
        void Sub(int a, int b);
    }

    internal class ClassTest : TestInterface2
    {
        void TestInterface.Add(int a, int b)
        {
            Console.WriteLine("Add = " + (a + b));
        }

        void TestInterface2.Sub(int a, int b)
        {
            Console.WriteLine("Sub = " + (a - b));
        }

        //public void Sub(int a, int b)
        //{
        //    Console.WriteLine("Sub = " + (a - b));
        //}

        //public void Add(int a, int b)
        //{
        //    Console.WriteLine("Add = " + (a + b));
        //}

        static void Main()
        {
            ClassTest c = new ClassTest();
            //c.Add(20 , 20);
            //c.Sub(100, 20);

            TestInterface2 i = c;
            i.Sub(10, 20);
            i.Add(10, 20);

            Console.ReadLine();
        }



    }

}
