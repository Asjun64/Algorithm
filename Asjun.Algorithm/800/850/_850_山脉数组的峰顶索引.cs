using System;
using System.Linq;

namespace Asjun.Algorithm._800._850
{
    /*
     * 序号：852
     * 难度：简单
     * 标签：二分查找
     
        我们把符合下列属性的数组 A 称作山脉：

            A.length >= 3
            存在 0 < i < A.length - 1 使得A[0] < A[1] < ... A[i-1] < A[i] > A[i+1] > ... > A[A.length - 1]
            给定一个确定为山脉的数组，返回任何满足 A[0] < A[1] < ... A[i-1] < A[i] > A[i+1] > ... > A[A.length - 1] 的 i 的值。

        示例 1：
            输入：[0,1,0]
            输出：1
        示例 2：
            输入：[0,2,1,0]
            输出：1
         
        提示：
            3 <= A.length <= 10000
            0 <= A[i] <= 10^6
            A 是如上定义的山脉
     */
    public class _850_山脉数组的峰顶索引
    {
        public int PeakIndexInMountainArray(int[] A)
        {
            if (A.Length < 3)
            {
                throw new ArgumentException("传入的数组需要至少包含 3 个元素！");
            }

            for (int i = 0; i < A.Length - 1; i++)
            {
                if (A[i] > A[i + 1])
                    return i;
            }
            return A.Length - 1;
        }
    }
}