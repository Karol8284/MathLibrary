using MathLibrary.Algebra;
using System;
using System.Collections.Generic;
using System.Text;
using MA = MathLibrary.Algebra;

namespace MathLibrary.Tests.Tests.Arithmetic
{
    public class BasicArithmeticTest
    {
        [Fact]
        public void TestAdd()
        {
            BasicAlgebra basicAlgebra = new();
            Assert.Equal(2, BasicAlgebra.Sqrt(4));
        }
    }
}
