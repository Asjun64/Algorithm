using Microsoft.VisualStudio.TestTools.UnitTesting;
using Asjun.Algorithm._800._830;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Asjun.Algorithm._800._830.Tests
{
    [TestClass()]
    public class _830_较大分组的位置_Tests
    {
        [TestMethod()]
        public void LargeGroupPositionsTest()
        {
            var solution = new _830_较大分组的位置();

            var S = "abbxxxxzzy";
            var target = new List<List<int>> { new List<int> { 3, 6 } };
            CollectionAssert.AreEqual(target.SelectMany(_ => _).ToList(), solution.LargeGroupPositions(S).SelectMany(_ => _).ToList());

            S = "abc";
            target = new List<List<int>> { };
            CollectionAssert.AreEqual(target.SelectMany(_ => _).ToList(), solution.LargeGroupPositions(S).SelectMany(_ => _).ToList());

            S = "abcdddeeeeaabbbcd";
            target = new List<List<int>> { new List<int> { 3, 5 }, new List<int> { 6, 9 }, new List<int> { 12, 14 }, };
            CollectionAssert.AreEqual(target.SelectMany(_ => _).ToList(), solution.LargeGroupPositions(S).SelectMany(_ => _).ToList());
        }
    }
}