using QueensPuzzleClassLibrary;
using System;
using System.Collections.Generic;
using System.Linq;

namespace QueensPuzzle
{
    class Program
    {
        static void Main(string[] args)
        {
            var queensFunction = new QueensFunction();

            //Console.WriteLine("4-queen puzzle：");
            //var result = queensFunction.SolveNQueens(4);
            //queensFunction.PrintPuzzle(result);

            Console.WriteLine("8-queen puzzle：");
            var result = queensFunction.SolveNQueens(8);
            queensFunction.PrintPuzzle(result);

            //Console.WriteLine("n-queen puzzle：n=?");
            //int n = 0;
            //var str = Console.ReadLine();
            //if(int.TryParse(str,out n))
            //{
            //    Console.WriteLine($"{n}-queen puzzle：");
            //    var result = queensFunction.SolveNQueens(n);
            //    queensFunction.PrintPuzzle(result);
            //}
        }

    }

}
