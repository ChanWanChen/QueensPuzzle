using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QueensPuzzle
{
    public class QueensFunction
    {
        public IList<IList<string>> SolveNQueens(int n)
        {
            List<IList<string>> result = new List<IList<string>>();
            var nQueens = new List<char[]>();//建置 n*n 的棋盤
            for (int i = 0; i < n; i++)
            {
                char[] row = new char[n];
                for (int j = 0; j < n; j++)
                {
                    row[j] = '.';
                }
                nQueens.Add(row);
            }

            SolveNQueensUtil(ref result, nQueens, 0, n);

            return result;
        }
        private void SolveNQueensUtil(ref List<IList<string>> result, List<char[]> nQueens, int row, int n)
        {
            if (row == n)
            {
                result.Add(nQueens.Select(c => new string(c)).ToList());
            }

            for (int col = 0; col < n; col++)
            {
                if (isvalid(nQueens, row, col, n))
                {
                    nQueens[row][col] = 'Q';
                    SolveNQueensUtil(ref result, nQueens, row + 1, n);
                    nQueens[row][col] = '.';
                }
            }
        }
        private bool isvalid(List<char[]> nQueens, int row, int col, int n)
        {
            //檢查上方同col 是否有Q
            for (int i = 0; i < row; i++)
            {
                if (nQueens[i][col] == 'Q')
                    return false;
            }
            //檢查斜前上方 是否有Q
            for (int i = row - 1, j = col - 1; i >= 0 && j >= 0; i--, j--)
            {
                if (nQueens[i][j] == 'Q')
                    return false;
            }
            //檢查斜後上方 是否有Q
            for (int i = row - 1, j = col + 1; i >= 0 && j < n; i--, j++)
            {
                if (nQueens[i][j] == 'Q')
                    return false;
            }

            return true;
        }
        public void PrintPuzzle(IList<IList<string>> puzzles)
        {
            for (int i = 0; i < puzzles.Count; i++)
            {
                Console.WriteLine($"Solution {i + 1}");
                for (int j = 0; j < puzzles[i].Count; j++)
                {
                    Console.WriteLine($"{puzzles[i][j]}");
                }
            }
        }
    }
}
