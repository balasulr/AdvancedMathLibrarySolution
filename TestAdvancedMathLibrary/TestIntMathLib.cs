//using System; //// Was conflicting with the AdvancedMathLibrary
using AdvancedMathLibrary;
using Xunit;

namespace TestAdvancedMathLibrary {
    public class TestIntMathLib {
        ///////////////////////////////////////////////////////////////////////////////////
        // Test cases for Divide by Zero function
        [Fact]
        public void TestDivideByZero() { // Should throw an exception if the second number is 0
            System.Action ZeroDenominator = () => Math.Divide(1, 0); // Defining another way to call this function
            Assert.Throws<System.DivideByZeroException>(ZeroDenominator); // Put in the expection that is expected when run
        }
        ///////////////////////////////////////////////////////////////////////////////////
        // Test cases for Divide function
        [Theory]
        [InlineData(1, 1, 1)]

        public void TestDivide(int expected, int x, int y) {
            Assert.Equal(expected, Math.Divide(x, y));
        }

        ///////////////////////////////////////////////////////////////////////////////////
        // Test cases for Multiply function
        [Theory]
        [InlineData(1, 1, 1)]
        [InlineData(20, 4, 5)]
        [InlineData(2400, 80, 30)]
        [InlineData(50, 5, 10)]
        [InlineData(100, 4, 25)]

        public void TestMultiply(int expected, int x, int y) {
            Assert.Equal(expected, Math.Multiply(x, y));
        }

        ///////////////////////////////////////////////////////////////////////////////////
        // Test cases for Subtract function
        [Theory]
        [InlineData(7, 15, 8)]
        [InlineData(20, 40, 20)]
        [InlineData(50, 80, 30)]
        [InlineData(5, 15, 10)]
        [InlineData(15, 40, 25)]

        public void TestSubtract(int expected, int x, int y) {
            Assert.Equal(expected, Math.Subtract(x, y));
        }

        ///////////////////////////////////////////////////////////////////////////////////
        // Test case for Adding function
        [Theory]
        [InlineData(0,0,0)] // First number is what value is expected
        [InlineData(0,5,-5)] // Other 2 numbers are what will be added
        [InlineData(-10,15,-25)]

        public void TestAdd(int expected, int a, int b) {
            Assert.Equal(expected, Math.Add(a, b));
        }
        ///////////////////////////////////////////////////////////////////////////////////
        // Testing the Absolute Value function
        [Theory]
        [InlineData(-3,3)] // What passing in (first number) & what expects to come out
        [InlineData(3,3)]
        [InlineData(0, 0)]

        public void TestAbsoluteValue(int input, int expected) { // Renamed so that know what is being tested in the method
        
            Assert.Equal(expected, Math.AbsoluteValue(input));
            
            //// Testing with 3
            //Assert.Equal(3, Math.AbsoluteValue(3));
            //Assert.Equal(0, Math.AbsoluteValue(0));
            
            // Assert is a class in the xUnit namespace. What the Equal does is
            // looks to see what value is expected to be and what the Actual value
            // will be. Want to have the Expected result match the actuak result.

        }
        ///////////////////////////////////////////////////////////////////////////////////
        [Fact] // Attribute because of the square bracket
        public void TestZeroConstant() {
            Assert.Equal(0, Math.Zero);
        ///////////////////////////////////////////////////////////////////////////////////
        }
    }
}
