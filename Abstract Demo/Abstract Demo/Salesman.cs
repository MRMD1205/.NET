using System;
using System.Collections.Generic;
using System.Text;

namespace Abstract_Demo
{
    abstract class Salesman
    {
        String firstName, lastName;


        public Salesman(string firstName, string lastName)
        {
            this.firstName = firstName;
            this.lastName = lastName;
        }

        public string FullName
        {
            get
            {
                return firstName + " " + lastName;
            }
        }
        public abstract void Sell();
    }
}
