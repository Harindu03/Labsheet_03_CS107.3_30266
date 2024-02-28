using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Labsheet_03_Q1
{
    public class course
    {
        private string courseName;
        private string instructorName;
        private double grade;

        public string Coursename;
        public double Grade
        {
            get { return grade; }
            set
            {
                if (value < 0 || value > 100)
                {
                    throw new ArgumentOutOfRangeException(nameof(value), "Grade must be between 0 and 100.");
                }
                grade = value;
            }
        }


        public course(string courseName, string instructorName, double grade)
        {
            this.courseName = courseName;
            setInstructorName(instructorName);
            Grade = grade;
        }
        public void setInstructorName(string name)
        {
            if (string.IsNullOrWhiteSpace(name))
            {
                throw new ArgumentNullException("instrutor cannot be empty");
            }
            instructorName = name;

        }
        private string CalculateGrade()
        {
            if (grade >= 75)
            {
                return "A";
            }
            else if (grade >= 65)
            {
                return "B";
            }
            else if (grade >= 55)
            { return "C"; }
            else if (grade >= 35)
            { return "S"; }
            else
            { return "F"; }

        }
        public void PrintcourseInfo()
        {
            string letterGrade = CalculateGrade();
            Console.WriteLine($"Course: {courseName}");
            Console.WriteLine($"Instructor: {instructorName}");
            Console.WriteLine($"Grade: {letterGrade}");
        }
        internal class Program

        {
            static void Main(string[] args)
            {
                course course = new course("OOP", "Mr Anton", 67);
                course.PrintcourseInfo();

            }
        }
    }
}
