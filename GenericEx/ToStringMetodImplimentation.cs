using System;
using System.Collections.Generic;
using System.Text;

namespace GenericEx1
{
    class ToStringMetodImplimentation
    {
        public static void Main()
        {
            Customer c1 = new Customer();
            c1.FirstName = "Sam";
            c1.LastName = "John";
            Console.WriteLine(c1.ToString());//default implimenation of c1 object

        }
    }


    public class Customer
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

    }
}
