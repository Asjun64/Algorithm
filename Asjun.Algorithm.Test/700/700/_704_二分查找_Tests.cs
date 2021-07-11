using Asjun.Algorithm._700._700;

using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Asjun.Algorithm._700._700.Tests
{
    [TestClass()]
    public class _704_二分查找_Tests
    {
        [TestMethod()]
        public void SearchTest()
        {
            var solution = new _704_二分查找();
            var nums = new int[] { -1, 0, 3, 5, 9, 12 };
            var target = 9;

            var result = solution.Search(nums, target);
            Assert.AreEqual(4, result);

            nums = new int[] { -1, 0, 3, 5, 9, 12 };
            target = 2;
            result = solution.Search(nums, target);
            Assert.AreEqual(-1, result);
        }
    }
}
