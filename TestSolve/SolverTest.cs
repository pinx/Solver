using FluentAssertions;
using Solve;
using System;
using System.Collections.Generic;
using System.Drawing;
using Xunit;

namespace TestSolve
{
    public class SolverTest
    {
        private Solver Solver = new Solver();

        [Fact]
        public void TestStartSolve()
        {
            this.Solver.Solve(new Problem()).Should().BeOfType<List<Rectangle>>();
        }
    }
}
