using Microsoft.VisualStudio.TestTools.UnitTesting;
using Asjun.Algorithm._800._840;

using System;
using System.Collections.Generic;
using System.Text;

namespace Asjun.Algorithm._800._840.Tests
{
    [TestClass()]
    public class _840_矩阵中的幻方_Tests
    {
        [TestMethod()]
        public void NumMagicSquaresInsideTest()
        {
            var solution = new _840_矩阵中的幻方();

            var grid = new int[][]
            {
                new int[] {4, 3, 8, 4},
                new int[] {9, 5, 1, 9},
                new int[] {2, 7, 6, 2},
            };
            Assert.AreEqual(1, solution.NumMagicSquaresInside(grid));

            grid = new int[][]
            {
                new int[] {5, 5, 5},
                new int[] {5, 5, 5},
                new int[] {5, 5, 5},
            };
            Assert.AreEqual(0, solution.NumMagicSquaresInside(grid));

            grid = new int[][]
            {
                new int[] {1, 8, 6},
                new int[] {10, 5, 0},
                new int[] {4, 2, 9},
            };
            Assert.AreEqual(0, solution.NumMagicSquaresInside(grid));

            grid = new[]
            {
                new[] {3, 2, 9, 2, 7},
                new[] {6, 1, 8, 4, 2},
                new[] {7, 5, 3, 2, 7},
                new[] {2, 9, 4, 9, 6},
                new[] {4, 3, 8, 2, 5}
            };
            Assert.AreEqual(1, solution.NumMagicSquaresInside(grid));
        }
    }
}