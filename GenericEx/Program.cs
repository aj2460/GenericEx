using System;

namespace GenericEx
{
    class Program
    {
        static void Main(string[] args)
        {
            string  ans =  Calculator.AreTheyEqual<int>(10, 20)?"True":"False";
            Console.WriteLine(ans);
            
        }
    }

    public class Calculator
    {
        public static bool AreTheyEqual<T>(T Value1, T Value2)
        {
            return Value1.Equals(Value2);
        }

    }
}
