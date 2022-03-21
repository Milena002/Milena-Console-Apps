using Microsoft.VisualStudio.TestTools.UnitTesting;
using ConsoleAppProject.App03;
/// <summary>
/// HERE IS SCHEMA OF MARKING:
/// Mark Range	Grade	Classification
///70 - 100      A       First Class
///60-69	     B	     Upper Second Class
/// 50-59	     C	     Lower Second Class
///40-49	     D	     Third Class
///0-39	         F	     Fail  
/// </summary>

namespace ConsoleAppUnitTest
{
   [TestClass]
    public class UnitTest3App03
    {
        private readonly StudentGrades
         studentgrades = new StudentGrades();

      

        private readonly int[] testMarks;
        private Grades[] testGrades;

        public UnitTest3App03()
        {
            testMarks = new int[] { 10, 20, 30, 40, 50, 60, 70, 80, 90, 100 };
            testGrades = new Grades[10];
        }
        //Grade F

        [TestMethod]
        public void TestConvert0toGradeF()
        {
            Grades expectedGrade = Grades.F;
            Grades actualGrade = studentgrades.ConvertToGrade(0);
            Assert.AreEqual(expectedGrade, actualGrade);
        }

        [TestMethod]
        public void TestConvert39toGradeF()
        {
            Grades expectedGrade = Grades.F;
            Grades actualGrade = studentgrades.ConvertToGrade(39);
            Assert.AreEqual(expectedGrade, actualGrade);
        }

        // Grade D

        [TestMethod]
        public void TestConvert40toGradeD()
        {
            Grades expectedGrade = Grades.D;
            Grades actualGrade = studentgrades.ConvertToGrade(40);
            Assert.AreEqual(expectedGrade, actualGrade);
        }

        [TestMethod]
        public void TestConvert49toGradeD()
        {
            Grades expectedGrade = Grades.D;
            Grades actualGrade = studentgrades.ConvertToGrade(49);
            Assert.AreEqual(expectedGrade, actualGrade);
        }
        // Grade C

        [TestMethod]
        public void TestConvert50toGradeC()
        {
            Grades expectedGrade = Grades.C;
            Grades actualGrade = studentgrades.ConvertToGrade(50);
            Assert.AreEqual(expectedGrade, actualGrade);
        }

        [TestMethod]
        public void TestConvert59toGradeC()
        {
            Grades expectedGrade = Grades.C;
            Grades actualGrade = studentgrades.ConvertToGrade(59);
            Assert.AreEqual(expectedGrade, actualGrade);
        }
        // Grade B
        [TestMethod]
        public void TestConvert60toGradeB()
        {
            Grades expectedGrade = Grades.B;
            Grades actualGrade = studentgrades.ConvertToGrade(60);
            Assert.AreEqual(expectedGrade, actualGrade);
        }

        [TestMethod]
        public void TestConvert69toGradeB()
        {
            Grades expectedGrade = Grades.B;
            Grades actualGrade = studentgrades.ConvertToGrade(69);
            Assert.AreEqual(expectedGrade, actualGrade);
        }

        // Grade A

        [TestMethod]
        public void TestConvert70toGradeA()
        {
            Grades expectedGrade = Grades.A;
            Grades actualGrade = studentgrades.ConvertToGrade(70);
            Assert.AreEqual(expectedGrade, actualGrade);
        }

        [TestMethod]
        public void TestConvert100toGradeA()
        {
            Grades expectedGrade = Grades.A;
            Grades actualGrade = studentgrades.ConvertToGrade(100);
            Assert.AreEqual(expectedGrade, actualGrade);
        }

        [TestMethod]
        public void TestCalculateMean()
        {
            studentgrades.Marks = testMarks;
            double expectedMean = 55;

            studentgrades.CalculateStats();
            Assert.AreEqual(expectedMean, studentgrades.Mean);
        }

        [TestMethod]
        public void TestCalculateMin()
        {
            studentgrades.Marks = testMarks;
            int expectedMinimum = 10;

            studentgrades.CalculateStats();
            Assert.AreEqual(expectedMinimum, studentgrades.Minimum);

        }

        [TestMethod]
        public void TestCalculateMax()
        {
            studentgrades.Marks = testMarks;
            int expectedMaximum = 100;

            studentgrades.CalculateStats();
            Assert.AreEqual(expectedMaximum, studentgrades.Maximum);
        }

       

    }
}
