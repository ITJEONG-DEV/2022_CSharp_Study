namespace CSharp.DefineIMyInterface
{
    using System;

    public interface IMyInterface
    {
        void MethodB();
    }
}

namespace CSharp.ExtensionMethod
{
    using System;
    using DefineIMyInterface;

    public static class Extension
    {
        public static void MethodA(this IMyInterface myInterface, int i)
        {
            Console.WriteLine("Extension.MethodA(this IMyInterface myInterface, int i)");
        }

        public static void MethodA(this IMyInterface myInterface, string s)
        {
            Console.WriteLine("Extension.MethodA(this IMyInterface myInterface, string s)");
        }
        public static void MethodB(this IMyInterface myInterface)
        {
            Console.WriteLine("Extension.MethodB(this IMyInterface myInterface");
        }
    }
}

namespace CSharp.ExtensionMethodExample
{
    using System;
    using CSharp.ExtensionMethod;
    using CSharp.DefineIMyInterface;

    class A : IMyInterface
    {
        public void MethodB() { Console.WriteLine("A.MethodB()"); }
    }

    class B : IMyInterface
    {
        public void MethodB() { Console.WriteLine("B.MethodB()"); }
        public void MethodA(int i) { Console.WriteLine("B.MethodA(int i)"); }
    }

    class C : IMyInterface
    {
        public void MethodB() { Console.WriteLine("C.MethodB()"); }
        public void MethodA(object obj) { Console.WriteLine("C.MethodA(object obj)"); }
    }

    class ExtensionMethodDemo
    {
        static void main(string[] args)
        {
            A a = new A();
            B b = new B();
            C c = new C();

            a.MethodA(1);               // Extension.MethodA(IMyInterface int);
            a.MethodA("hello");         // Extension.MethodA(IMyInterface, string);

            a.MethodB();                // A.MethodB()

            b.MethodA(1);               // B.MethodA(int);
            b.MethodB();                // B.MethodB();

            b.MethodA("hello");         // Extension.MethodA(IMyInterface, string);

            c.MethodA(2);               // C.MethodA(object)
            c.MethodA("hello");         // C.MethodA(object)
            c.MethodB();                // C.MethodB();

        }
    }
}
