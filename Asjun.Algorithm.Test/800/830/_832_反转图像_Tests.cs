using Microsoft.VisualStudio.TestTools.UnitTesting;
using Asjun.Algorithm._800._830;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Asjun.Algorithm._800._830.Tests
{
    [TestClass()]
    public class _832_反转图像_Tests
    {
        [TestMethod()]
        public void FlipAndInvertImageTest()
        {
            var solution = new _832_反转图像();

            var A = new int[][]
            {
                new int [] { 1, 1, 0 },
                new int [] { 1, 0, 1 },
                new int [] { 0, 0, 0 }
            };
            var target = new int[][]
            {
                new int[] {1, 0, 0},
                new int[] {0, 1, 0},
                new int[] {1, 1, 1},
            };
            var result = solution.FlipAndInvertImage(A);
            CollectionAssert.AreEqual(target.SelectMany(_ => _).ToList(), result.SelectMany(_ => _).ToList());

            A = new int[][]
            {
                new int[] {1, 1, 0, 0},
                new int[] {1, 0, 0, 1},
                new int[] {0, 1, 1, 1},
                new int[] {1, 0, 1, 0},
            };
            target = new int[][]
            {
                new int[] {1, 1, 0, 0},
                new int[] {0, 1, 1, 0},
                new int[] {0, 0, 0, 1},
                new int[] {1, 0, 1, 0},
            };
            result = solution.FlipAndInvertImage(A);
            CollectionAssert.AreEqual(target.SelectMany(_ => _).ToList(), result.SelectMany(_ => _).ToList());
        }
    }
}