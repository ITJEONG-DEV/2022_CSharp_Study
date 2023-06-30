using System;
using System.Reflection;

namespace Csharp.ReflectionExample
{
    class Animal
    {
        public int age;
        public string name;

        public Animal(string name, int age)
        {
            this.age = age;
            this.name = name;
        }

        public void eat()
        {
            Console.WriteLine("eat!");
        }

        public void sleep()
        {
            Console.WriteLine("sleep!");
        }
    }

    class Reflection
    {
        static void main(string[] args)
        {
            Animal animal = new Animal("cat", 4);
            Type type = animal.GetType();

            ConstructorInfo[] conInfo = type.GetConstructors();
            Console.Write("Constructor: ");
            foreach (ConstructorInfo tmp in conInfo)
                Console.Write("\t{0}", tmp);
            Console.WriteLine();

            MemberInfo[] memInfo = type.GetMethods();
            Console.Write("Methods: ");
            foreach (MethodInfo tmp in memInfo)
                Console.Write("\t{0}", tmp);
            Console.WriteLine();

            FieldInfo[] fieldInfo = type.GetFields();
            Console.Write("Fields: ");
            foreach (FieldInfo tmp in fieldInfo)
                Console.Write("\t{0}", tmp);
            Console.WriteLine();
        }
    }
}
