using System;
using System.Collections.Generic;
using System.Text;

namespace Asjun.Algorithm._000._000
{
    /**
     * URL：https://leetcode-cn.com/problems/longest-palindromic-substring/
     * 
     * 最长回文子串
     * 
     * 难度：中等
     * 
     * 标签：字符串、动态规划
     * 
        给你一个字符串 s，找到 s 中最长的回文子串。

        示例 1：
            输入：s = "babad"
            输出："bab"
            解释："aba" 同样是符合题意的答案。    

        示例 2：
            输入：s = "cbbd"
            输出："bb"

        示例 3：
            输入：s = "a"
            输出："a"

        示例 4：
            输入：s = "ac"
            输出："a"
 
        提示：
            1 <= s.length <= 1000
            s 仅由数字和英文字母（大写和/或小写）组成
     */
    public class _005_最长回文子串
    {
        public string LongestPalindrome(string s)
        {
            int index, length, maxIndex, maxLength;
            index = maxIndex = 0;
            length = maxLength = 1;
            bool isOdd = true;

            while (index < s.Length)
            {
                length = 1;
                while (index - length + 1 > 0 && index + length < s.Length)
                {
                    if (s[index - length] != s[index + length])
                    {
                        break;
                    }
                    length++;
                }
                if (length * 2 - 1 > maxLength * 2 - (isOdd ? 1 : 0))
                {
                    maxIndex = index;
                    maxLength = length;
                    isOdd = true;
                }


                length = 0;
                while (index - length >= 0 && index + 1 + length < s.Length)
                {
                    if (s[index - length] != s[index + 1 + length])
                    {
                        break;
                    }
                    length++;
                }
                if (length * 2 > maxLength * 2 - (isOdd ? 1 : 0))
                {
                    maxIndex = index;
                    maxLength = length;
                    isOdd = false;
                }

                index++;
            }

            return s.Substring(maxIndex - maxLength + 1, maxLength * 2 - (isOdd ? 1 : 0));

        }

    }
}
