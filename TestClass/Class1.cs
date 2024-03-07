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

        }
    }
}
