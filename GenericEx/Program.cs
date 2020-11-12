using System;

namespace GenericEx
{
    class Program
    {
        static void Main(string[] args)
        {
            string  ans =  Calculator.AreTheyEqual<int>(10, 20)?"True":"False";
            Console.WriteLine(ans);

            string ans1 = Calculator1<int>.AreTheyEqual(10, 10) ? "True" : "False";
            Console.WriteLine(ans1);
        }
    }

    public class Calculator
    {
        public static bool AreTheyEqual<T>(T Value1, T Value2)
        {
            return Value1.Equals(Value2);
        }

    }

    //Making class genetric

    public class Calculator1<T>
    {
        public static bool AreTheyEqual(T Value1, T Value2)
        {
            return Value1.Equals(Value2);
        }

    }
}
