namespace Asjun.Algorithm._800._840
{
    /*
        3 x 3 的幻方是一个填充有从 1 到 9 的不同数字的 3 x 3 矩阵，其中每行，每列以及两条对角线上的各数之和都相等。

        给定一个由整数组成的 grid，其中有多少个 3 × 3 的 “幻方” 子矩阵？（每个子矩阵都是连续的）。

     
        示例：
            输入: [[4,3,8,4],
                  [9,5,1,9],
                  [2,7,6,2]]
            输出: 1
            解释: 
                下面的子矩阵是一个 3 x 3 的幻方：
                438
                951
                276

                而这一个不是：
                384
                519
                762

        总的来说，在本示例所给定的矩阵中只有一个 3 x 3 的幻方子矩阵。
        提示:
            1 <= grid.length <= 10
            1 <= grid[0].length <= 10
            0 <= grid[i][j] <= 15
     */
    public class _840_矩阵中的幻方
    {
        public int NumMagicSquaresInside(int[][] grid)
        {
            if (grid.Length < 3 || grid[0].Length < 3)
            {
                return 0;
            }
            var cnt = 0;
            for (var i = 1; i < grid.Length - 1; i++)
            {
                for (var j = 1; j < grid[0].Length - 1; j++)
                {
                    if (grid[j][i] != 5) continue;
                    cnt += IsMagicSquare(grid, i, j) ? 1 : 0;
                    j++;
                }
            }
            return cnt;
        }

        private static bool IsMagicSquare(int[][] grid, int x, int y)
        {
            return Fun(grid[y - 1][x - 1]) &&
                   Fun(grid[y - 1][x + 1]) &&
                   Fun(grid[y - 1][x]) &&
                   Fun(grid[y][x - 1]) &&
                   grid[y - 1][x - 1] + grid[y + 1][x + 1] == 10 &&
                   grid[y - 1][x + 1] + grid[y + 1][x - 1] == 10 &&
                   grid[y - 1][x] + grid[y + 1][x] == 10 &&
                   grid[y][x - 1] + grid[y][x + 1] == 10 &&
                   grid[y - 1][x - 1] + grid[y][x - 1] + grid[y + 1][x - 1] == 15 &&
                   grid[y - 1][x - 1] + grid[y - 1][x] + grid[y - 1][x + 1] == 15;
        }

        private static bool Fun(int num)
        {
            return num != 5 && num > 0 && num < 10;
        }
    }
}