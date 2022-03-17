using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using ConsoleAppProject.Helpers;

namespace ConsoleAppProject.App03
{
    /// <summary>
    /// At the moment this class just tests the
    /// Grades enumeration names and descriptions
    /// </summary>
    public class StudentGrades
    {
        //constans grades
        public const int LowestMark = 0;
        public const int LowestGradeD = 40;
        public const int LowestGradeC = 50;
        public const int LowestGradeB = 60;
        public const int LowestGradeA = 70;
        public const int HighestMark = 100;

        //propetries
        public string[] Students { get; set; } 
        public int[] Marks { get; set; }
        public int[] GradeProfile { get; set; }

        public double Mean { get; set; }

        public int Minimum { get; set; }
        public int Maximum { get; set; }
        public void Run()
        {
            ConsoleHelper.OutputHeading("Students Marks");
            
        }
        public StudentGrades()
        {
            Students = new string[]
            {
                "Anna","Adam","Chloe", "Georgie",
                "Jacob", "Jenna", "Laura", "Max",
                "Nicole", "Tom", "Robin", "Victoria"
            };
            GradeProfile = new int[(int)Grades.A + 1];
            Marks = new int[Students.Length];

            InputMarks();
            OutputMarks();
        }
        //in this method allows user to input marks
        public void InputMarks()
        {
            ConsoleHelper.OutputTitle("Entering Student Marks");
            for(int index = 0; index < Students.Length; index++)
            {
              Marks[index] = (int)ConsoleHelper.InputNumber($"Please enter a percentage mark " +
                $"for: {Students[index]} ");
            }
        }
        //this method lists all the students and displays
        //their name and current mark
        public void OutputMarks()
        {
            ConsoleHelper.OutputTitle(" Student Marks");
            for (int index = 0; index < Students.Length; index++)
            {
               Console.WriteLine($"Mark " +
                $"for {Students[index]} = {Marks[index]}");
            }
        }
        // this method converting a student percentage mark to a letter grade
        public Grades ConvertToGrade(int mark)
        {
            if (mark >= LowestMark && mark < LowestGradeD)
            {
                return Grades.F;
            }
            if (mark >= LowestGradeD && mark < LowestGradeC)
            {
                return Grades.D;
            }
            if (mark >= LowestGradeC && mark < LowestGradeB)
            {
                return Grades.C;
            }
            if (mark >= LowestGradeB && mark < LowestGradeA)
            {
                return Grades.B;
            }
            if (mark >= LowestGradeA && mark < HighestMark)
            {
                return Grades.A;
            }
            else
            {
                return Grades.None;
            }
        }
        public void CalculateStats()
        {
            double total = 0;
            Minimum = HighestMark;
            Maximum = 0;

            foreach(int mark in Marks)
            {
                total = total + mark;
                if (mark > Maximum) Maximum = mark;
                if (mark < Minimum) Minimum = mark;
            }
            Mean = total / Marks.Length;
        }
        public void CalculateGradeProfile()
        {
            for(int i=0; i< GradeProfile.Length; i++)
            {
                GradeProfile[i] = 0;
            }
            foreach(int mark in Marks)
            {
                Grades grade = ConvertToGrade(mark);
                GradeProfile[(int)grade]++;
            }
            OutputGradeProfile();
        }

        private void OutputGradeProfile()
        {
            Grades grade = Grades.None;
            Console.WriteLine();
             
            foreach(int count in GradeProfile)
            {
                int percentage = count * 100 / Marks.Length;
                Console.WriteLine($"Grade {grade} {percentage} % Count {count}");
                grade++;
            }
        }
    }
}
