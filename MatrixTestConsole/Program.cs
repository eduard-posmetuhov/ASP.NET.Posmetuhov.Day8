using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MatrixLib;

namespace MatrixTestConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                SquareMatrix<int> squareMatrix1 = new SquareMatrix<int>(new int[,] { { 1, 2 }, { 3, 4 } });
                SquareMatrix<int> squareMatrix2 = new SquareMatrix<int>(new int[,] { { 1, 2 }, { 3, 4 } });
                //SquareMatrix<int> squareMatrix2 = new SquareMatrix<int>(new int[,]{{1,2,3},{4,5,6}});
                SymmetricalMatrix<int> symmetricalMatrix1 = new SymmetricalMatrix<int>((new int[,] { { 1, 1 }, { 1, 4 } }));
                //SymmetricalMatrix<int> symmetricalMatrix2 = new SymmetricalMatrix<int>((new int[,] { { 1, 2 }, { 1, 4 } }));
                SquareMatrix<int> squareMatrix3 = new SymmetricalMatrix<int>((new int[,] { { 1, 1 }, { 1, 4 } }));
                SymmetricalMatrix<int> symmetricalMatrix3 = (SymmetricalMatrix<int>)squareMatrix3;
                DiagonalMatrix<int> diagonalMatrix1 = new DiagonalMatrix<int>(new int[,] { { 1, 0 }, { 0, 1 } });
                var client = new Client1<int>(squareMatrix1);
                var client2 = new Client1<int>(symmetricalMatrix1);
                squareMatrix1[0, 0] = 2;
                symmetricalMatrix1[1, 0] = 2;
                Console.ReadKey();

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                Console.ReadKey();
            }
           
        }
    }
}
