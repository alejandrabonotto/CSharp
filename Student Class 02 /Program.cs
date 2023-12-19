using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment02_A
{
    abstract class Student
    {
        
        public abstract void study();

    }

    class RegularStudent : Student
    {
        
        public override void study()
        {
            Console.WriteLine("I am a regular student");
        }

    }

    class FasttrackStudent : Student
    {
        public override void study()
        {
            Console.WriteLine("I am a Fast track Student");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("My name: Alejandra Bonotto Farias Franco");
            Console.WriteLine("My Student Number: 301285530");

            Student s1 = new RegularStudent();
            s1.study();

            Student s2 = new FasttrackStudent();
            s2.study();
        }
    }

    
}
