using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using TriangleSolver;

namespace TestClass
{
    public class Class1
    {
        [TestFixture]
        public class TriangleTest1

        {
            // EQUILATERAL TRIANGLE

            [Test]
            public void ValidTriangle_Input60and60and60_OutputValidTriangle()
            {
                //Arrange
                int firstSide = 60;
                int secondSide = 60;
                int thirdSide = 60;
                string expected = "A triangle is formed and it is an EQUILATERAL";
                //Act
                string actual = Triangle.AnalyzeTriangle(firstSide, secondSide, thirdSide);

                //Assert
                Assert.AreEqual(expected, actual);
            }

             // ISOSCELES TRIANGLE

            [Test]
            public void IsoscelesTriangle_Input3and3and4_OutputIsoscelesTriangle()
            {
                // Arrange
                int sideA = 3;
                int sideB = 3;
                int sideC = 4;
                string expected = "A triangle is formed and it is an ISOSCELES";

                // Act
                string actual = Triangle.AnalyzeTriangle(sideA, sideB, sideC);

                // Assert
                Assert.AreEqual(expected, actual);
            }

            [Test]
            public void IsoscelesTriangle_Input5and7and7_OutputIsoscelesTriangle()
            {
                // Arrange
                int sideA = 5;
                int sideB = 7;
                int sideC = 7;
                string expected = "A triangle is formed and it is an ISOSCELES";

                // Act
                string actual = Triangle.AnalyzeTriangle(sideA, sideB, sideC);

                // Assert
                Assert.AreEqual(expected, actual);
            }

            [Test]
            public void IsoscelesTriangle_Input10and8and10_OutputIsoscelesTriangle()
            {
                // Arrange
                int sideA = 10;
                int sideB = 8;
                int sideC = 10;
                string expected = "A triangle is formed and it is an ISOSCELES";

                // Act
                string actual = Triangle.AnalyzeTriangle(sideA, sideB, sideC);

                // Assert
                Assert.AreEqual(expected, actual);
            }

            // SCALENE TRIANGLE

            [Test]
            public void ScaleneTriangle_Input3and4and5_OutputScaleneTriangle()
            {
                // Arrange
                int sideA = 3;
                int sideB = 4;
                int sideC = 5;
                string expected = "A triangle is formed and it is a SCALENE";

                // Act
                string actual = Triangle.AnalyzeTriangle(sideA, sideB, sideC);

                // Assert
                Assert.AreEqual(expected, actual);
            }

            [Test]
            public void ScaleneTriangle_Input9and12and15_OutputScaleneTriangle()
            {
                // Arrange
                int sideA = 9;
                int sideB = 12;
                int sideC = 15;
                string expected = "A triangle is formed and it is a SCALENE";

                // Act
                string actual = Triangle.AnalyzeTriangle(sideA, sideB, sideC);

                // Assert
                Assert.AreEqual(expected, actual);
            }

            [Test]
            public void ScaleneTriangle_Input7and24and25_OutputScaleneTriangle()
            {
                // Arrange
                int sideA = 7;
                int sideB = 24;
                int sideC = 25;
                string expected = "A triangle is formed and it is a SCALENE";

                // Act
                string actual = Triangle.AnalyzeTriangle(sideA, sideB, sideC);

                // Assert
                Assert.AreEqual(expected, actual);
            }

            [Test]
            public void ScaleneTriangle_Input5and12and13_OutputScaleneTriangle()
            {
                // Arrange
                int sideA = 5;
                int sideB = 12;
                int sideC = 13;
                string expected = "A triangle is formed and it is a SCALENE";

                // Act
                string actual = Triangle.AnalyzeTriangle(sideA, sideB, sideC);

                // Assert
                Assert.AreEqual(expected, actual);
            }

            [Test]
            public void ScaleneTriangle_Input8and15and17_OutputScaleneTriangle()
            {
                // Arrange
                int sideA = 8;
                int sideB = 15;
                int sideC = 17;
                string expected = "A triangle is formed and it is a SCALENE";

                // Act
                string actual = Triangle.AnalyzeTriangle(sideA, sideB, sideC);

                // Assert
                Assert.AreEqual(expected, actual);
            }





        
        }
    }
}
