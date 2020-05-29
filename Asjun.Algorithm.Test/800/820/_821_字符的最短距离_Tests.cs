using Microsoft.VisualStudio.TestTools.UnitTesting;
using Asjun.Algorithm._800._820;
using System;
using System.Collections.Generic;
using System.Text;

namespace Asjun.Algorithm._800._820.Tests
{
    [TestClass()]
    public class _821_字符的最短距离_Tests
    {
        [TestMethod()]
        public void ShortestToCharTest()
        {
            var solution = new _821_字符的最短距离();
            var S = "loveleetcode";
            var C = 'e';

            var target = new int[] { 3, 2, 1, 0, 1, 0, 0, 1, 2, 2, 1, 0 };
            CollectionAssert.AreEqual(target, solution.ShortestToChar(S, C));


        }
    }
}