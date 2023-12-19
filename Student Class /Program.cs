using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment01
{
    //creating a class called Student
    public class Student
    {
        private int studentNo;
        private string studentName;
        private double grade;

        public Student(int studentNo, string studentName, double grade) //constructor
        {
            this.studentNo = studentNo;
            this.studentName = studentName;
            this.grade = grade;
        }
        
        //getter and setter of properties
        public int StudentNo
        {
            get { return studentNo; }
            set { studentNo = value; }
        }

        public string StudentName
        {
            get { return studentName; }
            set { studentName = value; }
        }

        public double Grade
        {
            get { return grade; }
            set { grade = value; }
        }


        public void DisplayData()
        {
            Console.WriteLine($"Student number: {StudentNo};\nStudent name: {StudentName};\nStudent grade: {Grade}");
        }

        public override string ToString()
        {
            return "Student Number: " + studentNo + "\nStudent Name: " + studentName + "\nGrade: " + grade + "\n";
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {

            Student s1 = new Student (301295531, "Mary", 9.7); //creating an object through the constructor 
            Console.WriteLine(s1);//displaying information through ToString() implicitly

            //modifying the data of s1 through setters
            s1.StudentNo = 301285530;
            s1.StudentName = "Alejandra Bonotto";
            s1.Grade = 8.0;
            s1.DisplayData(); // displaying new information through DisplayData() explicitly

        }

    }




    
}
