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

            converter.fromDistance = 2.0;
            //Act
            converter.CalculateDistance();

            double expectedDistance = 10560;
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

            converter.fromDistance = 10560;
            //Act
            converter.CalculateDistance();

            double expectedDistance = 2.0;
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
         

            converter.fromDistance = 3218.69; 
            //Act
            converter.CalculateDistance();

            double expectedDistance = 2.0000062137273664;
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


            converter.fromDistance = 2.0;
            //Act
            converter.CalculateDistance();

            double expectedDistance = 3218.68; 
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


            converter.fromDistance = 6.56168;
            //Act
            converter.CalculateDistance();

            double expectedDistance = 2.0;
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


            converter.fromDistance = 2.0;
            //Act
            converter.CalculateDistance();

            double expectedDistance = 6.56168;
            //Assert
            Assert.AreEqual(expectedDistance, converter.toDistance);
        }

    }
}