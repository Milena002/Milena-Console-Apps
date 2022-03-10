using ConsoleAppProject.App01;
using ConsoleAppProject.App02;
using ConsoleAppProject.App03;
using ConsoleAppProject.Helpers;
using System;

namespace ConsoleAppProject
{
    /// <summary>
    /// The main method in this class is called first
    /// when the application is started.  It will be used
    /// to start App01 to App05 for CO453 CW1
    /// 
    /// This Project has been modified by: 
    /// Milena Michalska 10/02/2022
    /// </summary>
    public static class Program
    {
        public static int choice;

        public static BMI BMI
        {
            get => default;
            set
            {
            }
        }

        public static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;

            Console.WriteLine();
            Console.WriteLine(" =================================================");
            Console.WriteLine("    BNU CO453 Applications Programming 2021-2022! ");
            Console.WriteLine("                     by Milena                    ");
            Console.WriteLine(" =================================================");
            Console.WriteLine();

            string[] choices = new string[]
            {
               "Distance Converter",
               "BMI Calculator",
               "Student Marks",
            };
            ConsoleHelper.OutputTitle("Please selecet the application you wish to use:");
            choice = ConsoleHelper.SelectChoice(choices);
            
            if(choice == 1)
            {
                DistanceConverter converter = new DistanceConverter();
                converter.Run();
            }
            else if(choice == 2)
            {
                BMI calculator = new BMI();
                calculator.Run();
            }
            else if (choice == 3)
            {
                StudentGrades grades = new StudentGrades();
                grades.Run();
            }
        }
    }
}
