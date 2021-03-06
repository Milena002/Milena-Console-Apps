using System;
/// <summary>
/// This application converting distance units and below are all posibilites:
/// </summary>
namespace ConsoleAppProject.App01
{
    /// <summary>
    /// This class offer the user many options of converting between distances:
    ///1. feet to miles             | miles to feet
    ///2. metres to miles           | miles to metres
    ///3. feet to miles             | miles to feet
    ///4. metres to kilometres      | kilometres to metres
    ///5. kilometres to miles       | miles to kilometres
    ///6. feet to kilometres        | kilometres to feet
    ///7. yard to miles             | miles to yard
    ///8. yard to feet              | feet to yard
    ///9. yard to metres            | metres to yard
    ///10.yard to kilometres        | kilometres to yard
    ///11.centimetres to metres     | metres to centimetres
    ///12.centimetres to kilometres | kilometres to centimetres
    ///13.centimetres to miles      | miles to centimetres
    ///14.centimetres to feet       | feet to centimetres
    ///15.centimetres to yard       | yard to centimetres
    ///
    ///The user can select any combination of from and to distance units.
    /// </summary>
    /// <author>
    /// Milena version 1.5
    /// </author>
    public class DistanceConverter
    {
        // Distance conversion constants

        public const int    FEET_IN_MILES = 5280;
        public const double METRES_IN_MILES = 1609.34;
        public const double FEET_IN_METRES = 3.28084;

        public const double METRES_IN_KILOMETRES = 1000;
        public const double KILOMETRES_IN_MILES =1.60935;
        public const double KILOMETRES_IN_FEET = 0.0003048;
        public const double FEET_IN_YARD = 3;

        public const double YARD_IN_MILES = 1760.0066;
        public const double YARD_IN_METRES = 1.0936;
        public const double YARD_IN_KILOMETRES = 1093.6133;

        public const double CENTIMETRES_IN_FEET = 30.48;
        public const double CENTIMETRES_IN_MILES = 160935;
        public const double CENTIMETRES_IN_METRES = 100;
        public const double CENTIMETRES_IN_KILOMETRES = 100000;
        public const double CENTIMETRES_IN_YARD = 91.44;

        public const double INCH_IN_METRES = 39.3701;
        public const double INCH_IN_KILOMETRES = 39370.078;
        public const double INCH_IN_MILES = 63360.24;
        public const double INCH_IN_FEET = 12;
        public const double INCH_IN_YARD = 36;
        public const double CENTIMETRES_IN_INCH = 2.54;






        //Distance unit names

        public const string FEET = "feet";
        public const string METRES = "metres";
        public const string MILES = "miles";
        public const string KILOMETRES = "kilometres";
        public const string YARD = "yard";
        public const string CENTIMETERS = "centimetres";
        public const string INCH = "inch";





        public double fromDistance;
        public double toDistance;

        public string fromUnit;
        public string toUnit;

        public DistanceConverter()
        {
            fromUnit = MILES;
            toUnit = FEET;
        }

        public DistanceUnits DistanceUnits
        {
            get => default;
            set
            {
            }
        }

        /// <summary>
        /// this public method running the distance converter programm
        /// </summary>
        public void Run()
        {
            OutputHeading();
            do
            {
                fromUnit = SelectUnit(" Please select the from distance unit > ");
                if(fromUnit == null)
                     Console.WriteLine("Please select the correct option  from the list !");
                
            } while (fromUnit == null);
            
            do
            {
                toUnit = SelectUnit(" Please select the to distance unit > ");
                if (toUnit == null)
                    Console.WriteLine("Please select the correct option  from the list !");
            } while (toUnit == null);


                 Console.WriteLine($"\n Converting {fromUnit} to {toUnit}");
                fromDistance = InputDistance($" Please enter the number of {fromUnit} > ");
            

            CalculateDistance();

            OutputDistance();

        }

        public void CalculateDistance()
        {
            ///BASIC UNITS: MILE, FEET, METRES
            ///miles->feet
           if(fromUnit == MILES && toUnit == FEET)
            {
                toDistance = fromDistance * FEET_IN_MILES;
            }
           ///feet-> miles
           else if(fromUnit == FEET && toUnit == MILES)
            {
                toDistance = fromDistance / FEET_IN_MILES;
            }
           /// miles->metres
            else if (fromUnit == MILES && toUnit == METRES)
            {
                toDistance = fromDistance * METRES_IN_MILES;
            }
           ///metres->miles
            else if (fromUnit == METRES && toUnit == MILES)
            {
                toDistance = fromDistance / METRES_IN_MILES;
            }
           ///feet->metres
            else if (fromUnit == FEET && toUnit == METRES)
            {
                toDistance = fromDistance / FEET_IN_METRES;
            }
           ///metres->feet
            else if (fromUnit == METRES && toUnit == FEET)
            {
                toDistance = fromDistance * FEET_IN_METRES;
            }


           ///NEW UNIT KILOMETRES:
           ///metres->kilometres
            if (fromUnit == METRES && toUnit == KILOMETRES)
            {
                toDistance = fromDistance / METRES_IN_KILOMETRES;
            }
            ///kilometres-> metres
            else if (fromUnit == KILOMETRES && toUnit == METRES)
            {
                toDistance = fromDistance * METRES_IN_KILOMETRES;
            }
            ///kilometres->miles

            else if (fromUnit == KILOMETRES && toUnit == MILES)
            {
                toDistance = fromDistance / KILOMETRES_IN_MILES;
            }
            ///miles->kilometres
            else if (fromUnit == MILES && toUnit == KILOMETRES)
            {
                toDistance = fromDistance * KILOMETRES_IN_MILES;
            }
            ///kilometres->feet
            else if (fromUnit == KILOMETRES && toUnit == FEET)
            {
                toDistance = fromDistance / KILOMETRES_IN_FEET;
            }
            ///feet->kilometres
            else if (fromUnit == FEET && toUnit == KILOMETRES)
            {
                toDistance = fromDistance * KILOMETRES_IN_FEET;
            }


            /// NEW UNIT YARD:
            /// yard->feet
            if (fromUnit == YARD && toUnit == FEET)
            {
                toDistance = fromDistance * FEET_IN_YARD;
            }
            ///feet-> yard
            else if (fromUnit == FEET && toUnit == YARD)
            {
                toDistance = fromDistance / FEET_IN_YARD;
            }
            ///yard->miles

            else if (fromUnit == YARD && toUnit == MILES)
            {
                toDistance = fromDistance / YARD_IN_MILES;
            }
            ///miles->yard
            else if (fromUnit == MILES && toUnit == YARD)
            {
                toDistance = fromDistance * YARD_IN_MILES;
            }
            ///yard->metres
            else if (fromUnit == YARD && toUnit == METRES)
            {
                toDistance = fromDistance / YARD_IN_METRES;
            }
            ///metres->yard
            else if (fromUnit == METRES && toUnit == YARD)
            {
                toDistance = fromDistance * YARD_IN_METRES;
            }
            ///yard->kilometres
            else if (fromUnit == YARD && toUnit == KILOMETRES)
            {
                toDistance = fromDistance / YARD_IN_KILOMETRES;
            }
            ///kilometres->yard
            else if (fromUnit == KILOMETRES && toUnit == YARD)
            {
                toDistance = fromDistance * YARD_IN_KILOMETRES;
            }

            /// NEW UNIT CENTIMETRES:
            /// centimetres->feet
            if (fromUnit == CENTIMETERS && toUnit == FEET)
            {
                toDistance = fromDistance / CENTIMETRES_IN_FEET;
            }
            ///feet-> centimetres
            else if (fromUnit == FEET && toUnit == CENTIMETERS)
            {
                toDistance = fromDistance * CENTIMETRES_IN_FEET;
            }
            ///centimetres->miles

            else if (fromUnit == CENTIMETERS && toUnit == MILES)
            {
                toDistance = fromDistance / CENTIMETRES_IN_MILES;
            }
            ///miles->centimetres
            else if (fromUnit == MILES && toUnit == CENTIMETERS)
            {
                toDistance = fromDistance * CENTIMETRES_IN_MILES;
            }
            ///centimetres->metres
            else if (fromUnit == CENTIMETERS && toUnit == METRES)
            {
                toDistance = fromDistance / CENTIMETRES_IN_METRES;
            }
            ///metres->centimetres
            else if (fromUnit == METRES && toUnit == CENTIMETERS)
            {
                toDistance = fromDistance * CENTIMETRES_IN_METRES;
            }
            ///centimetres->kilometres
            else if (fromUnit == CENTIMETERS && toUnit == KILOMETRES)
            {
                toDistance = fromDistance / CENTIMETRES_IN_KILOMETRES;
            }
            ///kilometres->centimetres
            else if (fromUnit == KILOMETRES && toUnit == CENTIMETERS)
            {
                toDistance = fromDistance * CENTIMETRES_IN_KILOMETRES;
            }
            ///yard -> centimetres
            else if (fromUnit == YARD && toUnit == CENTIMETERS)
            {
                toDistance = fromDistance * CENTIMETRES_IN_YARD;
            }
            ///centimetres->yard
            else if (fromUnit == CENTIMETERS && toUnit == YARD)
            {
                toDistance = fromDistance / CENTIMETRES_IN_YARD;
            }


            /// NEW UNIT INCH:
            /// inch->feet
            if (fromUnit == INCH && toUnit == FEET)
            {
                toDistance = fromDistance / INCH_IN_FEET;
            }
            ///feet-> inch
            else if (fromUnit == FEET && toUnit == INCH)
            {
                toDistance = fromDistance * INCH_IN_FEET;
            }
            ///inch->miles

            else if (fromUnit == INCH && toUnit == MILES)
            {
                toDistance = fromDistance / INCH_IN_MILES;
            }
            ///miles->inch
            else if (fromUnit == MILES && toUnit == INCH)
            {
                toDistance = fromDistance * INCH_IN_MILES;
            }
            ///inch->metres
            else if (fromUnit == INCH && toUnit == METRES)
            {
                toDistance = fromDistance / INCH_IN_METRES;
            }
            ///metres->centimetres
            else if (fromUnit == METRES && toUnit == INCH)
            {
                toDistance = fromDistance / INCH_IN_METRES;
            }
            ///inch->kilometres
            else if (fromUnit == INCH && toUnit == KILOMETRES)
            {
                toDistance = fromDistance * INCH_IN_KILOMETRES;
            }
            ///kilometres->inch
            else if (fromUnit == KILOMETRES && toUnit == INCH)
            {
                toDistance = fromDistance * INCH_IN_KILOMETRES;
            }
            ///inch -> centimetres
            else if (fromUnit == INCH && toUnit == CENTIMETERS)
            {
                toDistance = fromDistance * CENTIMETRES_IN_INCH;
            }
            ///centimetres->inch
            else if (fromUnit == CENTIMETERS && toUnit == INCH)
            {
                toDistance = fromDistance / CENTIMETRES_IN_INCH;
            }
            ///inch -> yard
            else if (fromUnit == INCH && toUnit == YARD)
            {
                toDistance = fromDistance / INCH_IN_YARD;
            }
            ///yard -> inch
            else if (fromUnit == YARD && toUnit == INCH)
            {
                toDistance = fromDistance * INCH_IN_YARD;
            }

        }

        /// <summary>
        /// Display a menu of distance unit and prompt
        /// user to select the  one and return it.
        /// </summary>
        private string SelectUnit(string prompt)
        {
            string choice = DisplayChoices(prompt);
            string unit = ExecuteChoice(choice);
            Console.WriteLine($"\n You have chosen:  -> {unit}");
            return unit;
        }

        private static string ExecuteChoice(string choice)
        {
           

            if (choice.Equals("1"))
            {
                return FEET;
            }
            else if (choice == "2")
            {
                return METRES;
            }

            else if (choice.Equals("3"))
            {
                return MILES;
            }

            else if (choice.Equals("4"))
            {
                return KILOMETRES;
            }

            else if (choice.Equals("5"))
            {
                return YARD;
            }
            else if (choice.Equals("6"))
            {
                return CENTIMETERS;
            }
            else if (choice.Equals("7"))
            {
                return INCH;
            }
            else
            {
                return null;
            }
         
            }

        private static string DisplayChoices(string prompt)
        {
            Console.WriteLine();
            Console.WriteLine($"1. {FEET}");
            Console.WriteLine($"2. {METRES}");
            Console.WriteLine($"3. {MILES}");
            Console.WriteLine($"4. {KILOMETRES}");
            Console.WriteLine($"5. {YARD}");
            Console.WriteLine($"6. {CENTIMETERS}");
            Console.WriteLine($"7. {INCH}");


            Console.WriteLine();

            Console.Write(prompt);
            string choice = Console.ReadLine();
            return choice;
        }

        /// <summary>
        /// Prompt the user to enter the distance in miles
        /// input the miles as a duble number.
        /// </summary>
        private double InputDistance(string prompt)
        {
            Console.Write(prompt);
            string value = Console.ReadLine();
           if(Double.TryParse(value, out double fromDistance))
            {
                fromDistance = Convert.ToDouble(value);
                if(fromDistance < 0)
                {
                    fromDistance = InputDistance(" Wrong Distance! Please Input a valid distance > ");
                }
                return fromDistance;
            }
            else
            {
                fromDistance = InputDistance("Wrong Distance! Please Input a valid distance >");
                return fromDistance;
            }
        }
        
       
        /// <summary>
        /// this private method displaying the  result in feets
        /// </summary>
        private void OutputDistance()
        {
            Console.WriteLine($" \n {fromDistance} {fromUnit}" +
                $" is --> {toDistance} {toUnit}!\n");
        }
        
        private void OutputHeading()
        {
            Console.WriteLine("\n--------------------------------------------------");
            Console.WriteLine("                 Distance  Conventer                ");
            Console.WriteLine("                 by Milena Michalska                ");
            Console.WriteLine(" -------------------------------------------------\n");

        }
    }
}
