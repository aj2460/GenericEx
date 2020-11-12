using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace GenericEx
{
    class EqualsMethodOverride
    {
        public static void Main()
        {
            Customer c1 = new Customer();
            c1.FirstName = "Sam";
            c1.LastName = "James";

            //Customer c2 = c1;
            Customer c2 = new Customer();
            c2.FirstName = "Sam";
            c2.LastName = "James";

            Console.WriteLine(c1 == c2);   // check reference equality
            Console.WriteLine(c1.Equals(c2)); // check value equality
        }
    }

    class Customer
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public override bool Equals(object obj)
        {
            if (obj == null)
                return false;

            if(!(obj is Customer))
            {
                return false;
            }

            return this.FirstName == ((Customer)obj).FirstName && this.LastName == ((Customer)obj).LastName;
        }

        public override int GetHashCode()
        {
            return FirstName.GetHashCode() ^ LastName.GetHashCode();
        }
    }
}
