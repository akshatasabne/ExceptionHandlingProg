using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandlingProg
{
    public class AgeException:Exception
    {
        
            public AgeException(string message) : base(message)
            {

            }
   

        public class Student
        {
            private string name;
            private int age;

            public void AcceptDetails(string name, int age)
            {
               
                if (string.IsNullOrEmpty(name))
                {
                    throw new AgeException("Name is required");
                }
                else
                {
                    this.name = name;
                    this.age = age;
                }

            }
        }
    }
}
