using MathLibrary.Tests.Helper;
using System;
using System.Collections.Generic;
using System.Text;

namespace MathLibrary.Tests.Tests
{
    public class SumTests
    {
        [Fact]
        public void Sum_Int()
        {
            MatyLibraryAssert.Sum(17, 2, 4, 5, 6);
        }
        [Fact]
        public void Sum_Double()
        {
            MatyLibraryAssert.Sum(17.0, 2.0, 4.0, 5.0, 6.0);
        }
        [Fact]
        public void Sum_Float()
        {
            MatyLibraryAssert.Sum(17.0f, 2.0f, 4.0f, 5.0f, 6.0f);
        }
    }
}
