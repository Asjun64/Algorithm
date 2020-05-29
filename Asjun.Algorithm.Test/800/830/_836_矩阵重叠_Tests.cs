using Microsoft.VisualStudio.TestTools.UnitTesting;
using Asjun.Algorithm._800._830;
using System;
using System.Collections.Generic;
using System.Text;

namespace Asjun.Algorithm._800._830.Tests
{
    [TestClass()]
    public class _836_矩阵重叠_Tests
    {
        [TestMethod()]
        public void IsRectangleOverlapTest()
        {
            var solution = new _836_矩阵重叠();

            var rec1 = new int[] { 0, 0, 2, 2 };
            var rec2 = new int[] { 1, 1, 3, 3 };
            Assert.AreEqual(true, solution.IsRectangleOverlap(rec1, rec2));

            rec1 = new int[] { 0, 0, 1, 1 };
            rec2 = new int[] { 1, 0, 2, 1 };
            Assert.AreEqual(false, solution.IsRectangleOverlap(rec1, rec2));

            rec1 = new int[] { 7, 8, 13, 15 };
            rec2 = new int[] { 10, 8, 12, 20 };
            Assert.AreEqual(true, solution.IsRectangleOverlap(rec1, rec2));
        }
    }
}