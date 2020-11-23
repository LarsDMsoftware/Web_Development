using System;
using System.Collections.Generic;
using System.Text;

namespace _1_PersonEncapsulation
{
    class Person
    {
        // Fields //
        private DateTime birthday { get; set; }
        private string firstName { get; set; }
        private string lastName { get; set; }
        private static int instanceCount { get; set; }

        // Properties //
        public int Age
        {
            get 
            { 
                return DateTime.Now.Year - birthday.Year; 
            }
        }
        public string FullName
        {
            get
            {
                return $"{firstName} {lastName}";
            }

        }
        public static int InstanceCount
        {
            get 
            {
                return instanceCount;
            }
        }

        // Constructor
        public Person(string firstName, string lastName, DateTime birthday)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.birthday = birthday;
            instanceCount++;
        }

        public override string ToString()
        {
            return String.Format("{0} is {1} jaar oud", FullName,Age);
        }
    }
}
