using Microsoft.VisualStudio.TestTools.UnitTesting;
using Asjun.Algorithm._800._811;
using System;
using System.Collections.Generic;
using System.Text;

namespace Asjun.Algorithm._800._811.Tests
{
    [TestClass()]
    public class _812_最大三角形面积_Tests
    {
        [TestMethod()]
        public void LargestTriangleAreaTest()
        {
            var solution = new _812_最大三角形面积();

            var points = new int[][] {
                new int[] {0, 0},
                new int[] {0, 1},
                new int[] {1, 0},
                new int[] {0, 2},
                new int[] {2, 0},
            };
            Assert.AreEqual(2, solution.LargestTriangleArea(points));
        }
    }
}