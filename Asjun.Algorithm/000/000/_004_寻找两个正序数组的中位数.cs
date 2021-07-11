using System;
using System.Collections.Generic;
using System.Text;

namespace Asjun.Algorithm._000._000
{
    /**
     * TODO: 抄作业
     * 
     * URL：https://leetcode-cn.com/problems/median-of-two-sorted-arrays
     * 
     * 004.寻找两个正序数组的中位数
     * 
     * 给定两个大小分别为 m 和 n 的正序（从小到大）数组 nums1 和 nums2。请你找出并返回这两个正序数组的 中位数 。

        示例 1：
            输入：nums1 = [1,3], nums2 = [2]
            输出：2.00000
            解释：合并数组 = [1,2,3] ，中位数 2

        示例 2：
            输入：nums1 = [1,2], nums2 = [3,4]
            输出：2.50000
            解释：合并数组 = [1,2,3,4] ，中位数 (2 + 3) / 2 = 2.5

        示例 3：
            输入：nums1 = [0,0], nums2 = [0,0]
            输出：0.00000

        示例 4：
            输入：nums1 = [], nums2 = [1]
            输出：1.00000

        示例 5：
            输入：nums1 = [2], nums2 = []
            输出：2.00000
 
        提示：
            nums1.length == m
            nums2.length == n
            0 <= m <= 1000
            0 <= n <= 1000
            1 <= m + n <= 2000
            -106 <= nums1[i], nums2[i] <= 106
 
        进阶：你能设计一个时间复杂度为 O(log (m+n)) 的算法解决此问题吗？
     */
    public class _004_寻找两个正序数组的中位数
    {
        public double FindMedianSortedArrays(int[] nums1, int[] nums2)
        {
            int m = nums1.Length;
            int n = nums2.Length;
            int left = (m + n + 1) / 2;
            int right = (m + n + 2) / 2;
            return (FindK(nums1, 0, nums2, 0, left) + FindK(nums1, 0, nums2, 0, right)) / 2.0;
        }

        /// <summary>
        /// 从两个有序数组中，找出第 k 个数（按大小排列）
        /// </summary>
        /// <param name="nums1"></param>
        /// <param name="i">nums1 数组的起始位置</param>
        /// <param name="nums2"></param>
        /// <param name="j">nums2 数组的起始位置</param>
        /// <param name="k"></param>
        /// <returns></returns>
        private int FindK(int [] nums1, int i, int[] nums2, int j, int k)
        {
            if (i >= nums1.Length) return nums2[j + k - 1]; // nums1 为空数组
            if (j >= nums2.Length) return nums1[i + k - 1]; // nums2 为空数组
            if (k == 1)
            {
                return Math.Min(nums1[i], nums2[j]);
            }
            int midVal1 = (i + k / 2 - 1 < nums1.Length) ? nums1[i + k / 2 - 1] : int.MaxValue;
            int midVal2 = (j + k / 2 - 1 < nums2.Length) ? nums1[i + k / 2 - 1] : int.MaxValue;
            if (midVal1 < midVal2)
            {
                return FindK(nums1, i + k / 2, nums2, j, k - k / 2);
            }
            else
            {
                return FindK(nums1, i, nums2, j + k / 2, k - k / 2);
            }
        }
    }
}
