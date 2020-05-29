using Microsoft.VisualStudio.TestTools.UnitTesting;
using Asjun.Algorithm._800._840;

using System;
using System.Collections.Generic;
using System.Text;

namespace Asjun.Algorithm._800._840.Tests
{
    [TestClass()]
    public class _844_比较含退格的字符串_Tests
    {
        [TestMethod()]
        public void BackspaceCompareTest()
        {
            var solution = new _844_比较含退格的字符串();

            string S = "ab#c", T = "ab#c";
            Assert.AreEqual(true, solution.BackspaceCompare(S, T));

            S = "ab##";
            T = "c#d#";
            Assert.AreEqual(true, solution.BackspaceCompare(S, T));

            S = "a##c"; 
            T = "#a#c";
            Assert.AreEqual(true, solution.BackspaceCompare(S, T));

            S = "a#c";
            T = "b";
            Assert.AreEqual(false, solution.BackspaceCompare(S, T));

            S = "aaa###a";
            T = "aaaa###a";
            Assert.AreEqual(false, solution.BackspaceCompare(S, T));

        }
    }
}