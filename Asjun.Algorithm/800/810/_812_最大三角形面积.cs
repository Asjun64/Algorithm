﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Asjun.Algorithm._800._811
{
    /*
       给定包含多个点的集合，从其中取三个点组成三角形，返回能组成的最大三角形的面积。

        示例:
            输入: points = [[0,0],[0,1],[1,0],[0,2],[2,0]]
            输出: 2
            解释: 
                这五个点如下图所示。组成的橙色三角形是最大的，面积为2。

        注意:
            3 <= points.length <= 50.
            不存在重复的点。
            -50 <= points[i][j] <= 50.
            结果误差值在 10^-6 以内都认为是正确答案。
     */
    public class _812_最大三角形面积
    {
        public double LargestTriangleArea(int[][] points)
        {
            var res = 0.0;
            for (int i = 0; i < points.Length; i++)
            {
                for (int j = i + 1; j < points.Length; j++)
                {
                    for (int k = j + 1; k < points.Length; k++)
                    {
                        res = Math.Max(res, getTriangleArea(points[i], points[j], points[k]));
                    }
                }
            }
            return res;
        }

        /// <summary>
        /// 鞋带公式求三角形面积
        /// </summary>
        private double getTriangleArea(int[] a, int[] b, int[] c)
        {
            return 0.5 * Math.Abs(a[0] * b[1] + b[0] * c[1] + c[0] * a[1]
                                - a[1] * b[0] - b[1] * c[0] - c[1] * a[0]);
        }
    }
}
