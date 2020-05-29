using Microsoft.VisualStudio.TestTools.UnitTesting;
using Asjun.Algorithm._800._811;
using System;
using System.Collections.Generic;
using System.Text;

namespace Asjun.Algorithm._800._811.Tests
{
    [TestClass()]
    public class _819_最常见的单词_Tests
    {
        [TestMethod()]
        public void MostCommonWordTest()
        {
            var solution = new _819_最常见的单词();
            var paragraph = "Bob hit a ball, the hit BALL flew far after it was hit.";
            var banner = new string[] { "hit" };

            Assert.AreEqual("ball", solution.MostCommonWord(paragraph, banner));

            paragraph = "Bob. hIt, baLl";
            banner = new string[] { "bob", "hit" };
            Assert.AreEqual("ball", solution.MostCommonWord(paragraph, banner));
        }
    }
}