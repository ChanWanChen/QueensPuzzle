using Microsoft.VisualStudio.TestTools.UnitTesting;
using QueensPuzzleClassLibrary;
using System.Collections.Generic;

namespace QueensPuzzleTest
{
    [TestClass]
    public class UnitTest
    {
        [TestMethod]
        public void _4QueensPuzzle()
        {
            IList<IList<string>> expect = new List<IList<string>>();
            expect.Add(new List<string>() { ".Q..", "...Q", "Q...", "..Q."});
            expect.Add(new List<string>() { "..Q.", "Q...", "...Q", ".Q.."});
            
            var queensFunction = new QueensFunction();
            var result = queensFunction.SolveNQueens(4);

            //Assert.AreEqual(expect, result); //false
            //Assert.ReferenceEquals(expect, result); //true
            for (int i = 0; i < result.Count; i++)
            {
                for (int j = 0; j < result[i].Count; j++)
                {
                    Assert.AreEqual(expect[i][j], result[i][j]);
                }
            }
        }
    }
}
