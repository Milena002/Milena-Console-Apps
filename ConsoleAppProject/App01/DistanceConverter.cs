using System;

namespace ConsoleAppProject.App01
{
    /// <summary>
    ///This App allows the user to convert distances
    ///measured in one unit of distance into another 
    ///unit of distance, for example it will convert 
    ///a distance measured in miles into the same distance
    ///measured in feet.
    /// </summary>
    /// <author>
    /// Milena version 0.1
    /// </author>
    public class DistanceConverter
    {
        private double miles;
        private double feet;
        /// <summary>
        /// this public method running the distance converter programm
        /// </summary>
        public void Run()
        {
            InputMiles();
            CalculateFeet();
            OutputFeet();

        }
        /// <summary>
        /// this is private method to enter the miles
        /// </summary>
        private void InputMiles()
        {
            Console.Write("Please enter the number of miles > ");
            string value = Console.ReadLine();
            miles = Convert.ToDouble(value); 
        }
        /// <summary>
        /// this is private method to change the distance to the feet
        /// </summary>
        private void CalculateFeet()
        {

        }
        /// <summary>
        /// this private method displaying the  result in feets
        /// </summary>
        private void OutputFeet()
        {

        }

    }
}
