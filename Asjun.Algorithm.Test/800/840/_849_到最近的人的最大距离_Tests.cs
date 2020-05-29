using Microsoft.VisualStudio.TestTools.UnitTesting;
using Asjun.Algorithm._800._840;

using System;
using System.Collections.Generic;
using System.Text;

namespace Asjun.Algorithm._800._840.Tests
{
    [TestClass()]
    public class _849_到最近的人的最大距离_Tests
    {
        [TestMethod()]
        public void MaxDistToClosestTest()
        {
            var solution = new _849_到最近的人的最大距离();

            var seats = new int[] {1, 0, 0, 0, 1, 0, 1};
            Assert.AreEqual(2, solution.MaxDistToClosest(seats));

            seats = new[] {1, 0, 0, 0};
            Assert.AreEqual(3, solution.MaxDistToClosest(seats));
        }
    }
}