using NUnit.Framework;  // Make sure this is included
using Lab_3;            // Assuming your Triangle class is in the Lab_3 namespace

namespace Lab_3.Tests
{
    [TestFixture]
    public class TriangleTests
    {
        [Test]
        public void TestIsoscelesTriangle_ReturnsTrue_WhenTwoSidesAreEqual()
        {
            // Arrange: Create an instance of the Triangle class
            var triangle = new Triangle();

            // Define two sides to be equal (5, 5, 8)
            int side1 = 5;
            int side2 = 5;
            int side3 = 8;

            // Act: Call the IsIsosceles method
            bool result = triangle.IsIsosceles(side1, side2, side3);

            // Assert: The result should be true because two sides are equal
            Assert.That(result, Is.True, "The triangle should be isosceles when two sides are equal.");
        }

        [Test]
        public void TestNonIsoscelesTriangle_ReturnsFalse_WhenAllSidesAreDifferent()
        {
            // Arrange: Create an instance of the Triangle class
            var triangle = new Triangle();

            // Define all sides to be different (3, 4, 5)
            int side1 = 3;
            int side2 = 4;
            int side3 = 5;

            // Act: Call the IsIsosceles method
            bool result = triangle.IsIsosceles(side1, side2, side3);

            // Assert: The result should be false because all sides are different
            Assert.That(result, Is.False, "The triangle should not be isosceles when all sides are different.");
        }
    }
}
