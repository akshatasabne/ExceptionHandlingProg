using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static ExceptionHandlingProg.AgeException;

namespace ExceptionHandlingProg
{
    public class Program
    {
       
        static void Main(string[] args)
        {
            Student stud = new Student();
            try
            {
                stud.AcceptDetails("",19);
            }
            catch (AgeException ex)
            {
                Console.WriteLine(ex.Message);
            }
           

        }
    }
}