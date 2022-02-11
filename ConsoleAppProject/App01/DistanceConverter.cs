using System;

namespace ConsoleAppProject.App01
{
    /// <summary>
    ///This App allows the user to convert distances
    ///measured in one unit of distance into another 
    ///unit of distance, for example it will convert :
    ///1. a distance measured in miles into the same distance measured in feet.
    ///2. a distance measured in miles into the same distance measured in metres.
    ///3. a distance measured in feet into the same distance measured in miles.
    /// </summary>
    /// <author>
    /// Milena version 0.1
    /// </author>
    public class DistanceConverter
    {
        public const int FEET_IN_MILES = 5280;
        public const double METRES_IN_MILES = 1609.34;
        private double miles;
        private double feet;
        private double metres;
        /// <summary>
        /// this public method running the distance converter programm
        /// </summary>
        public void MilesToFeet()
        {
            OutputHeading("Converting Miles to Feet");
           
            miles =  InputDistance("Please enter the number of miles > ");

            CalculateFeet();

            OutputDistance(miles,nameof(miles), feet, nameof(feet));

        }
        public void FeetToMiles()
        {
            OutputHeading("Converting Feet to Miles");

            feet = InputDistance("Please enter the number of feet > ");
            CalculateMiles();
            OutputDistance(feet, nameof(feet), miles, nameof(miles));

        }
        public void MilesToMetres()
        {
            OutputHeading("Converting Miles to Metres ");

            metres = InputDistance("Please enter the number of miles > ");
            CalculateMetres();
            OutputDistance(miles, nameof(miles), metres, nameof(metres));

        }
        

        /// <summary>
        /// this is private method to enter the miles by user
        /// </summary>
        private double InputDistance(string prompt)
        {
            Console.Write(prompt);
            string value = Console.ReadLine();
            return Convert.ToDouble(value); 
        }
        /// <summary>
        /// this is private method to enter the meters by user
        /// </summary>
    
        /// <summary>
        /// this is private method to change the distance to the feet
        /// </summary>
        /// 
        private void CalculateFeet()
        {
            feet = miles * FEET_IN_MILES;
        }

        /// <summary>
        /// this is private method to change the distance to the miles
        /// </summary>
        /// 
        private void CalculateMiles()
        {
            miles = feet /  FEET_IN_MILES;
        }

        /// <summary>
        /// this is private method to change the distance to the metres
        /// </summary>
        /// 
        private void CalculateMetres()
        {
            metres = miles * METRES_IN_MILES ;
        }
        /// <summary>
        /// this private method displaying the  result in feets
        /// </summary>
        private void OutputDistance(
            double fromDistance, string  fromUnit,
            double toDistance, string toUnit)
        {
            Console.WriteLine($" {fromDistance} {fromUnit} is {toDistance} {toUnit}");
        }
        
        private void OutputHeading(String prompt)
        {
            Console.WriteLine("\n--------------------------------------------------");
            Console.WriteLine("                 Distance  Conventer                ");
            Console.WriteLine("                 by Milena Michalska                ");
            Console.WriteLine(" -------------------------------------------------\n");

            Console.WriteLine(prompt);
            Console.WriteLine();
        }
    }
}
