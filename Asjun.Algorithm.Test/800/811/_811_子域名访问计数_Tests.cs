using Microsoft.VisualStudio.TestTools.UnitTesting;
using Asjun.Algorithm._800._811;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Asjun.Algorithm._800._811.Tests
{
    [TestClass()]
    public class _811_子域名访问计数_Tests
    {
        [TestMethod()]
        public void SubdomainVisitsTest()
        {
            var solution = new _811_子域名访问计数();

            var cpdomains = new string[] { "9001 discuss.leetcode.com" };
            var target = new List<string> { "9001 discuss.leetcode.com", "9001 leetcode.com", "9001 com" };
            var result = solution.SubdomainVisits(cpdomains).ToList();
            CollectionAssert.AreEquivalent(target, result);

            cpdomains = new string[] { "900 google.mail.com", "50 yahoo.com", "1 intel.mail.com", "5 wiki.org" };
            target = new List<string> { 
                "901 mail.com", "50 yahoo.com", "900 google.mail.com", "5 wiki.org", "5 org", "1 intel.mail.com", "951 com" };
            result = solution.SubdomainVisits(cpdomains).ToList();
            CollectionAssert.AreEquivalent(target, result);

        }
    }
}