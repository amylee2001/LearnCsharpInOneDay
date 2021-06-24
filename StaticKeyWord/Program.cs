using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticKeyWord
{

    class MyClass
    {
        //Non static members
        public string message = "Hello World";
        public string Name { get; set; }
        public void DisplayName()
        {
            Console.WriteLine("Name = {0}", Name);
        }

        //Static members
        public static string greetings = "Good Morning";
        public static int Age { get; set; }
        public static void DisplayAge()
        {
            Console.WriteLine("Age = {0}", Age);
        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            MyClass classA = new MyClass();

            Console.WriteLine(classA.message);
            classA.Name = "Simon";
            classA.DisplayName();

            Console.WriteLine(MyClass.greetings);
            MyClass.Age = 62;
            MyClass.DisplayAge();

            Console.Read();
        }
    }
}
