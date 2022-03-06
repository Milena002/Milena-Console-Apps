using Microsoft.VisualStudio.TestTools.UnitTesting;
using ConsoleAppProject.App01;
namespace ConsoleAppUnitTest
{
    [TestClass]
    public class UnitTestApp01
    {
     
        // test miles -> feet
        [TestMethod]
        public void TestMilestoFeet()
        {//Arrange
            DistanceConverter converter = new DistanceConverter();
            converter.fromUnit = DistanceConverter.MILES;
            converter.toUnit = DistanceConverter.FEET;

            converter.fromDistance = 1.0;
            //Act
            converter.CalculateDistance();

            double expectedDistance = 5280;
            //Assert
            Assert.AreEqual(expectedDistance, converter.toDistance);


        }
        //test feet->miles
        [TestMethod]
        public void TestFeettoMiles()
        {
            //Arrange
            DistanceConverter converter = new DistanceConverter();
            converter.toUnit = DistanceConverter.MILES;
            converter.fromUnit = DistanceConverter.FEET;

            converter.fromDistance = 5280;
            //Act
            converter.CalculateDistance();

            double expectedDistance = 1.0;
            //Assert
            Assert.AreEqual(expectedDistance, converter.toDistance);
        }

        //test metres -> miles
        [TestMethod]
        public void TestMeterstoMiles()
        {
            //Arrange
            DistanceConverter converter = new DistanceConverter();

            converter.fromUnit = DistanceConverter.METRES;
            converter.toUnit = DistanceConverter.MILES;
         

            converter.fromDistance = 1609.34; ;
            //Act
            converter.CalculateDistance();

            double expectedDistance = 1.0;
            //Assert
            Assert.AreEqual(expectedDistance, converter.toDistance);
        }

        //test miles -> metres
        [TestMethod]
        public void TestMilestoMetres()
        {
            //Arrange
            DistanceConverter converter = new DistanceConverter();

            converter.fromUnit = DistanceConverter.MILES;
            converter.toUnit = DistanceConverter.METRES;


            converter.fromDistance = 1.0  ;
            //Act
            converter.CalculateDistance();

            double expectedDistance = 1609.34; 
            //Assert
            Assert.AreEqual(expectedDistance, converter.toDistance);
        }


        //test feet -> metres
        [TestMethod]
        public void FeettoMetres()
        {
            //Arrange
            DistanceConverter converter = new DistanceConverter();

            converter.fromUnit = DistanceConverter.FEET;
            converter.toUnit = DistanceConverter.METRES;


            converter.fromDistance = 3.28084; 
            //Act
            converter.CalculateDistance();

            double expectedDistance = 1.0;
            //Assert
            Assert.AreEqual(expectedDistance, converter.toDistance);
        }
        //test metres -> feet
        [TestMethod]
        public void MetrestoFeet()
        {
            //Arrange
            DistanceConverter converter = new DistanceConverter();

            converter.fromUnit = DistanceConverter.METRES;
            converter.toUnit = DistanceConverter.FEET;


            converter.fromDistance = 1.0;
            //Act
            converter.CalculateDistance();

            double expectedDistance = 3.28084;
            //Assert
            Assert.AreEqual(expectedDistance, converter.toDistance);
        }

    }
}