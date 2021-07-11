using Microsoft.VisualStudio.TestTools.UnitTesting;
using Asjun.Algorithm._000._000;

using System;
using System.Collections.Generic;
using System.Text;

namespace Asjun.Algorithm._000._000.Tests
{
    [TestClass()]
    public class _004_寻找两个正序数组的中位数Tests
    {
        [TestMethod()]
        public void FindMedianSortedArraysTest()
        {
            var solution = new _004_寻找两个正序数组的中位数();
            var nums1 = new int[] { 1, 3 };
            var nums2 = new int[] { 2 };

            Assert.AreEqual(2.0, solution.FindMedianSortedArrays(nums1, nums2));

            nums1 = new int[] { 1, 2 };
            nums2 = new int[] { 3, 4 };
            Assert.AreEqual(2.5, solution.FindMedianSortedArrays(nums1, nums2));

            nums1 = new int[] { 0, 0 };
            nums2 = new int[] { 0, 0 };
            Assert.AreEqual(0.0, solution.FindMedianSortedArrays(nums1, nums2));

            nums1 = new int[] { };
            nums2 = new int[] { 1};
            Assert.AreEqual(1.0, solution.FindMedianSortedArrays(nums1, nums2));

            nums1 = new int[] { 2 };
            nums2 = new int[] { };
            Assert.AreEqual(2.0, solution.FindMedianSortedArrays(nums1, nums2));

        }
    }
}