using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Asjun.Algorithm._800._820
{
    /*
        给定一个字符串 S 和一个字符 C。返回一个代表字符串 S 中每个字符到字符串 S 中的字符 C 的最短距离的数组。

        示例 1:
            输入: S = "loveleetcode", C = 'e'
            输出: [3, 2, 1, 0, 1, 0, 0, 1, 2, 2, 1, 0]
            说明:
                字符串 S 的长度范围为 [1, 10000]。
                C 是一个单字符，且保证是字符串 S 里的字符。
                S 和 C 中的所有字母均为小写字母。
    */
    public class _821_字符的最短距离
    {
        public int[] ShortestToChar(string S, char C)
        {
            var list = new int[S.Length];
            var prev = -S.Length;
            for (int i = 0; i < S.Length; i++)
            {
                if (S[i] == C) prev = i;
                list[i] = i - prev;
            }
            prev = S.Length*2;
            for (int i = S.Length - 1; i >= 0; i--)
            {
                if (S[i] == C) prev = i;
                list[i] = Math.Min(list[i], prev - i);
            }
            return list;
        }
    }
}
