using System;
using System.Collections.Generic;
using Xunit;

namespace CodingChallenges1.Tests
{
    public class ChallengeTests
    {
        [Theory]
        [InlineData(1, 1, true)]
        [InlineData(10, 10, true)]
        [InlineData(99, 99, true)]
        [InlineData(-10, -10, true)]
        [InlineData(-1, -1, true)]
        [InlineData(0, 1, false)]
        [InlineData(4, 7, false)]
        [InlineData(-1, 1, false)]
        [InlineData(5, 6, false)]
        public void AreTwoNumbersTheSame(int number1, int number2, bool expected)
        {
            // Arrange
            Challenges challenger = new Challenges();

            // Act
            bool actual = challenger.AreTwoNumbersTheSame(number1, number2);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(10, 7, 3)]
        [InlineData(100, 75, 25)]
        [InlineData(1, 1, 0)]
        [InlineData(10, 15, -5)]
        [InlineData(0, 7, -7)]
        [InlineData(0, 0, 0)]
        [InlineData(-5, 5, -10)]
        [InlineData(-10, -7, -3)]
        [InlineData(-10, -15, 5)]
        [InlineData(5.5, 1.2, 4.3)]
        [InlineData(0.70, 0.35, 0.35)]
        [InlineData(-2.2, 1.0, -3.2)]
        public void Subtract(double minuend, double subtrahend, double expectedDifference)
        {
            // Arrange - by setting a new instance
            Challenges challenger = new Challenges();

            // Act
            double actual = challenger.Subtract(minuend, subtrahend);

            // Assert
            Assert.Equal(expectedDifference, actual);
        }

        [Theory]
        [InlineData(10, 7, 17)]
        [InlineData(100, 75, 175)]
        [InlineData(1, 1, 2)]
        [InlineData(10, 15, 25)]
        [InlineData(0, 7, 7)]
        [InlineData(0, 0, 0)]
        [InlineData(-5, 5, 0)]
        [InlineData(-10, -7, -17)]
        [InlineData(-10, -15, -25)]
        public void Add(int addend1, int addend2, int expectedSum)
        {
            // Arrange
            Challenges challenger = new Challenges();

            // Act
            int actual = challenger.Add(addend1, addend2);

            // Assert
            Assert.Equal(expectedSum, actual);
        }

        [Theory]
        [InlineData(10, 7, 7)]
        [InlineData(100, 75, 75)]
        [InlineData(1, 1, 1)]
        [InlineData(10, 15, 10)]
        [InlineData(0, 7, 0)]
        [InlineData(0, 0, 0)]
        [InlineData(-5, 5, -5)]
        [InlineData(-10, -7, -10)]
        [InlineData(-10, -15, -15)]
        public void GetSmallestNumber(int number1, int number2, int expected)
        {
            // Arrange
            Challenges challenger = new Challenges();

            // Act
            int actual = challenger.GetSmallestNumber(number1, number2);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(10, 7, 70)]
        [InlineData(100, 75, 7500)]
        [InlineData(1, 1, 1)]
        [InlineData(10, 15, 150)]
        [InlineData(0, 7, 0)]
        [InlineData(0, 0, 0)]
        [InlineData(-5, 5, -25)]
        [InlineData(-10, -7, 70)]
        [InlineData(-10, -15, 150)]
        [InlineData(1234567, 7654321, 9449772114007)]
        [InlineData(1234567, -7654321, -9449772114007)]
        public void Multiply(long factor1, long factor2, long product)
        {
            // Arrange
            Challenges challenger = new Challenges();

            // Act
            long actual = challenger.Multiply(factor1, factor2);

            // Assert
            Assert.Equal(product, actual);
        }

        [Theory]
        [InlineData("John", "Hello, John!")]
        [InlineData("Leigh", "Hello, Leigh!")]
        [InlineData("John Thomas", "Hello, John Thomas!")]
        [InlineData("Leigh Ann", "Hello, Leigh Ann!")]
        [InlineData("", "Hello!")]
        // [InlineData(null, "Hello!")] // Assumption: string will not be null
        public void GetGreeting(string personName, string expectedGreeting)
        {
            // Arrange
            Challenges challenger = new Challenges();

            // Act
            string actual = challenger.GetGreeting(personName);

            // Assert
            Assert.Equal(expectedGreeting, actual);
        }

        [Fact]
        public void GetHey()
        {
            // Arrange
            Challenges challenger = new Challenges();

            // Act
            string actual = challenger.GetHey();

            // Assert
            Assert.Equal("HEY!", actual);
        }
    }
}
