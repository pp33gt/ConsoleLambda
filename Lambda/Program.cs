using System;
using System.Linq.Expressions;

namespace Lambda
{
    public class SomeClass
    {
        public SomeClass()
        {
        }

        public string GetHello()
        {
            return "Hello";
        }

        public string GetGoodBye()
        {
            return "Good Bye";
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            ExpressionTest();

        }

        private static void ExpressionTest()
        {
            Console.WriteLine("Hello World!");

            var sayHello = true;

            Expression<Func<SomeClass, string>> hello = (c => c.GetHello());

            Expression<Func<SomeClass, string>> goodbye = (c => c.GetGoodBye());

            var say = (sayHello) ? hello : goodbye;
            var methodName = (say.Body as MethodCallExpression).Method.Name;
        }
    }
}
