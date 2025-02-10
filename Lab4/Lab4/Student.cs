using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{
    class Student
    {
        private string ssn;
        private int age;
        private string address, name; 
        
        public Student ()
        {
            this.name = "No Name Intialized Yet";
            this.address = " No Address Intialized Yet";
            this.ssn = " SSN Not Intialized Yet"; 
        }

        public Student(string name , string ssn , int age , string address)
        {
            this.name = name;
            this.ssn = ssn;
            this.age = age;
            this.address = address; 
        }

        public string SSN
        {
            get
            {
               return  this.ssn; 
            }
            set 
            {
                if (value.Length == 14)
                {
                    this.ssn = value;
                }
                else
                {
                    throw new Exception("SSN Must be 14 number ");
                }
            }

        }

        public string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                this.name = value;
            }
        }

        public int Age
        {
            get
            {
                return this.age; 
            }
            set
            {
                this.age = value; 
            }
        }

        public string Address
        {
            get
            {
                return this.address; 
            }
            set
            {
                this.address = value;
            }
        }



        public string Print()
        {
            return $"Name : {this.name} , SSN : {this.ssn} , Age : {this.age} , Address : {this.address}"; 
        }

    }
}
