using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace A7
{
    public class Student
    {
        public string? CourseNameCode;
        public int? CourseUnit;
        public int? CourseScore;
        public char Grade;
        public string? Remark;
        public int? WeightPt;
        public int? TotalCourseUnitRegistered;
        public int? TotalCourseUnitpassed;
        public int? TotalWeightPoint;
        public float GPA;
        public string? StudentChoice;

        public void Display()
        {            

            do
            {
                Console.WriteLine("Please enter your course name and code: ");
                CourseNameCode = Console.ReadLine().ToUpper();

                do
                {
                    Console.WriteLine("Please enter your course unit: ");
                    CourseUnit = Convert.ToInt32(Console.ReadLine());  
                }while (CourseUnit < 0 || CourseUnit == null);

                do
                {
                    Console.WriteLine("Please enter your course score: ");
                    CourseScore = Convert.ToInt32(Console.ReadLine());
                } while (CourseScore < 0 || CourseScore == null);

                if (CourseScore < 0 || CourseScore > 5 )
                {
                    Console.WriteLine("Please enter a valid CourseScore");
                }
                else if (CourseScore == 5)
                {
                    Grade = 'A';
                    Remark = "Excellent";
                    Console.WriteLine($"Grade : {Grade} Remark : {Remark}");
                }
                else if (CourseScore == 4)
                {
                    Grade = 'B';
                    Remark = "Very Good";
                    Console.WriteLine($"Grade : {Grade} Remark : {Remark}");
                }
                else if (CourseScore == 3)
                {
                    Grade = 'C';
                    Remark = "Good";
                    Console.WriteLine($"Grade : {Grade} Remark : {Remark}");
                }
                else if (CourseScore == 2)
                {
                    Grade = 'D';
                    Remark = "Fair";
                    Console.WriteLine($"Grade : {Grade} Remark : {Remark}");
                }
                else if (CourseScore == 1)
                {
                    Grade = 'E';
                    Remark = "Pass";
                    Console.WriteLine($"Grade : {Grade} Remark : {Remark}");
                }
                else
                {
                    Grade = 'F';
                    Remark = "Fail";
                    Console.WriteLine($"Grade : {Grade} Remark : {Remark}");
                }
                do
                {
                    Console.WriteLine("Would you like to enter another course - YES or NO?");
                    StudentChoice = Console.ReadLine().ToUpper();
                }while (StudentChoice != "YES" && StudentChoice != "NO");
            }while(StudentChoice == "YES");

        }
    }
}