using Microsoft.VisualStudio.TestTools.UnitTesting;
using Asjun.Algorithm._800._800;
using System;
using System.Collections.Generic;
using System.Text;

namespace Asjun.Algorithm._800._800.Tests
{
    [TestClass()]
    public class _804_唯一摩尔斯密码词_Tests
    {
        [TestMethod()]
        public void UniqueMorseRepresentationsTest()
        {
            var words = new string[] {"gin", "zen", "gig", "msg"};
            var solution = new _804_唯一摩尔斯密码词();
            Assert.AreEqual(2, solution.UniqueMorseRepresentations(words));
        }
    }
}