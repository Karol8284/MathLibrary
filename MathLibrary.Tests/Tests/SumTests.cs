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
    }
}
