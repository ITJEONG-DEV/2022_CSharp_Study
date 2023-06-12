namespace CSharp.Delegate
{
    using System;

    class DelegateExample
    {
        // A delegate is a type that safety encapsulates a method (similar to a function pointer in C and C++)
        // delegates are object-oriented, type safe, and secure
        // declares a delegate named "Del" that cna encapsulate a method
        public delegate void Del(string message);

        // A delegate object is normally constructed by providing the name of the method the delegate will wrap, or with a lambda expression
        public static void DelegateMethod(string message)
        {
            Console.WriteLine(message);
        }

        // common use of callbacks is defining a custom comparison method and passing that delegate to a sort method
        // this method use the "Del" type as a parameter
        public static void MethodWithCallback(int param1, int param2, Del callback)
        {
            callback("The number is: " + (param1 + param2).ToString());
        }

        public class MethodClass
        {
            public void Method1(string msg)
            {
                Console.WriteLine("Method1: " + msg);
            }
            public void Method2(string msg)
            {
                Console.WriteLine("Method2: " + msg);
            }
        }


        static void main(string[] args)
        {
            // An instantiated delegate can be invoked as if it were the wrapped method itself
            Del handler = DelegateMethod;
            handler("Hello World");

            // pass the delegated created above to method
            MethodWithCallback(1, 2, handler);

            // A delegate can call more than one method when invoked
            // simply requires adding two delegates using the addition or addition assignment operators ('+' or '+=')
            // To remove a method from the invocation list, use the subtraction or subtraction assgignment operators ('-' or '-=')
            var obj = new MethodClass();
            Del d1 = obj.Method1;
            Del d2 = obj.Method2;
            Del d3 = DelegateMethod;

            Del allMethodsDelegate = d1 + d2 + d3;
            Del oneMethodDelegate = allMethodsDelegate - d1 - d2;
            allMethodsDelegate("msg");

            // Because delegate types are derived from "System.Delegate", the methods and properties defined by that class can be called on the delegate
            // To find the number of methods in a delegate's invocation list, you may wrtie:
            int invocationCount = d1.GetInvocationList().GetLength(0);
        }
    }
    
    // .NET 7 Preview 5
    //delegate void PDelegate(int a, int b);
    //class Delegate
    //{
    //    static void Plus(int a, int b)
    //    {
    //        Console.WriteLine("{0} + {1} = {2}", a, b, a + b);
    //    }

    //    static void Minus(int a, int b)
    //    {
    //        Console.WriteLine("{0} - {1} = {2}", a, b, a - b);
    //    }

    //    static void Division(int a, int b)
    //    {
    //        Console.WriteLine("{0} / {1} = {2}", a, b, a / b);
    //    }

    //    static void Multiplication(int a, int b)
    //    {
    //        Console.WriteLine("{0} * {1} = {2}", a, b, a * b);
    //    }

    //    static void main(string[] args)
    //    {
    //        PDelegate pd = (PDelegate)Delegate.Combine(
    //            new PDelegate(Plus),
    //            new PDelegate(Minus),
    //            new PDelegate(Division),
    //            new PDelegate(Multiplication)
    //        );

    //    }
    //}
}
