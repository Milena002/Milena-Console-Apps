using System;

namespace ConsoleAppProject.App01
{
    /// <summary>
    /// This class offesr the user a way of converting between distances:
    ///1. a distance measured in miles into the same distance measured in feet.
    ///2. a distance measured in miles into the same distance measured in metres.
    ///3. a distance measured in feet into the same distance measured in miles.
    ///The user can select any combination of from and to distance units.
    /// </summary>
    /// <author>
    /// Milena version 1.4
    /// </author>
    public class DistanceConverter
    {
        // Distance conversion constants

        public const int FEET_IN_MILES = 5280;
        public const double METRES_IN_MILES = 1609.34;
        public const double FEET_IN_METRES = 3.28084;
        
        //Distance unit names

        public const string FEET = "feet";
        public const string METRES = "metres";
        public const string MILES = "miles";

        private double fromDistance;
        private double toDistance;

        private string fromUnit;
        private string toUnit;
        
        public DistanceConverter()
        {
            fromUnit = MILES;
            toUnit = FEET;
        }
        /// <summary>
        /// this public method running the distance converter programm
        /// </summary>
        public void ConvertDistance()
        {
            fromUnit = SelectUnit("Please select the from distance unit > ");
            toUnit = SelectUnit("Please select the to distance unit > ");

            OutputHeading($"Converting {fromUnit} to {toUnit}");

           fromDistance= InputDistance($"Please enter the number of {fromUnit}> ");
            

            //CalculateFeet();

            OutputDistance();

        }

        private string SelectUnit(string prompt)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Prompt the user to enter the distance in miles
        /// input the miles as a duble number.
        /// </summary>
        private double InputDistance(string prompt)
        {
            Console.Write(prompt);
            string value = Console.ReadLine();
            return Convert.ToDouble(value); 
        }
        
       
        /// <summary>
        /// this private method displaying the  result in feets
        /// </summary>
        private void OutputDistance()
        {
            Console.WriteLine($" {fromDistance} {fromUnit} " +
                $" is {toDistance} {toUnit}!");
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
