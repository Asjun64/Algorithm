using Microsoft.VisualStudio.TestTools.UnitTesting;
using Asjun.Algorithm._800._820;
using System;
using System.Collections.Generic;
using System.Text;

namespace Asjun.Algorithm._800._820.Tests
{
    [TestClass()]
    public class _824_山羊拉丁文_Tests
    {
        [TestMethod()]
        public void ToGoatLatinTest()
        {
            var solution = new _824_山羊拉丁文();

            var S = "I speak Goat Latin";
            var target = "Imaa peaksmaaa oatGmaaaa atinLmaaaaa";
            var result = solution.ToGoatLatin(S);
            Assert.AreEqual(target, result);

            S = "The quick brown fox jumped over the lazy dog";
            target = "heTmaa uickqmaaa rownbmaaaa oxfmaaaaa umpedjmaaaaaa overmaaaaaaa hetmaaaaaaaa azylmaaaaaaaaa ogdmaaaaaaaaaa";
            result = solution.ToGoatLatin(S); 
            Assert.AreEqual(target, result);
        }
    }
}