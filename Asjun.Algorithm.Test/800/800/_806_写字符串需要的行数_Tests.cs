using Microsoft.VisualStudio.TestTools.UnitTesting;
using Asjun.Algorithm._800._800;
using System;
using System.Collections.Generic;
using System.Text;

namespace Asjun.Algorithm._800._800.Tests
{
    [TestClass()]
    public class _806_写字符串需要的行数_Tests
    {
        [TestMethod()]
        public void NumberOfLinesTest()
        {
            var solution = new _806_写字符串需要的行数();

            var widths = new int[] { 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10 };
            var S = "abcdefghijklmnopqrstuvwxyz";
            var result = solution.NumberOfLines(widths, S);
            CollectionAssert.AreEqual(new int[] { 3, 60 }, result);

            widths = new int[] { 4, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10 };
            S = "bbbcccdddaaa";
            result = solution.NumberOfLines(widths, S);
            CollectionAssert.AreEqual(new int[] { 2, 4 }, result);
        }
    }
}