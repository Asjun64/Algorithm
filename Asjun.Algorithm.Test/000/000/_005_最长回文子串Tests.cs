using Microsoft.VisualStudio.TestTools.UnitTesting;
using Asjun.Algorithm._000._000;

using System;
using System.Collections.Generic;
using System.Text;

namespace Asjun.Algorithm._000._000.Tests
{
    [TestClass()]
    public class _005_最长回文子串Tests
    {
        [TestMethod()]
        public void LongestPalindromeTest()
        {
            var solution = new _005_最长回文子串();

            var s = "babad";
            Assert.AreEqual("bab", solution.LongestPalindrome(s));

            s = "cbbd";
            Assert.AreEqual("bb", solution.LongestPalindrome(s));

            s = "a";
            Assert.AreEqual("a", solution.LongestPalindrome(s));

            s = "ac";
            Assert.AreEqual("a", solution.LongestPalindrome(s));

            s = "bb";
            Assert.AreEqual("bb", solution.LongestPalindrome(s));
        }
    }
}