using System;
using System.Collections.Generic;
using System.Text;

using M = MathLibrary.Maty;

namespace MathLibrary.Tests.Tests
{
    public class MathLibraryTest_OldVersion
    {
        //Ściąga dla mnie do nauki
        // Arrange
        // Act
        // Assert
        [Fact]
        public void Sum_ReturnCorrectValue_ForInts()
        {
            //Arrange
            int[] values = { 2, 4, 5, 6 };
            //Act
            var result = M.Sum(values);
            //Assert
            Assert.Equal(17, result);
        }
        [Fact]
        public void Sum_ReturnCorrectValue_ForDoubles()
        {
            //Arrange
            double[] doubleValues = { 2.0, 4.0, 5.0, 6.0 };
            //Act
            var result2 = M.Sum(doubleValues);
            //Assert
            Assert.Equal(17.0, result2);
        }
        [Fact]
        public void Sum_ReturnCorrectValue_ForDecimals()
        {
            //Arrange
            decimal[] decimalValues = { 2.0m, 4.0m, 5.0m, 6.0m };
            //Act
            var result = M.Sum(decimalValues);
            //Assert
            Assert.Equal(17.0m, result);
        }

        [Theory]
        [InlineData(13, new int[] { 2, 4, 5, 2 })]
        [InlineData(20, new int[] { 2, 4, 5, 6, 3 })]
        public void Sum_Ints_Works(int expected, int[] values)
        {
            var result = M.Sum(values);
            Assert.Equal(expected, result);
        }
    }
}
