using Microsoft.VisualStudio.TestTools.UnitTesting;
using Asjun.Algorithm._800._850;

using System;
using System.Collections.Generic;
using System.Text;

namespace Asjun.Algorithm._800._850.Tests
{
    [TestClass()]
    public class _850_山脉数组的峰顶索引_Tests
    {
        [TestMethod()]
        public void PeakIndexInMountainArrayTest()
        {
            var solution = new _850_山脉数组的峰顶索引();

            var A = new [] {0, 1, 0};
            Assert.AreEqual(1, solution.PeakIndexInMountainArray(A));

            A = new[] {0, 2, 1, 0};
            Assert.AreEqual(1, solution.PeakIndexInMountainArray(A));

            A = new[] {1, 0, 0};
            Assert.AreEqual(0, solution.PeakIndexInMountainArray(A));

            A = new[] {0, 1, 0};
            Assert.AreEqual(1, solution.PeakIndexInMountainArray(A));

            A = new[] { 0, 0 };
            Assert.ThrowsException<ArgumentException>(() =>
            {
                solution.PeakIndexInMountainArray(A);
            });
        }
    }
}