using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatrixLib
{
    public class DiagonalMatrix<T> : SymmetricalMatrix<T> 
    {
        public DiagonalMatrix(T[,] sourse):base (sourse)
        {
            for (int i = 0; i < Size; i++)
                for (int j = 0; j < Size; j++)
                    if (i!=j && !sourse[j, i].Equals(default(T)))
                      throw new ArgumentException("Matrix is not diagonal");
        }
        public DiagonalMatrix(int size):base (size)
        { }

        public override T this[int row, int column]
        {
            get
            {
                if ((row >= 0 && row < Size) && (column >= 0 && column < Size))
                    if (row != column)
                        return default(T);
                    else
                    return body[row, column];
                throw new IndexOutOfRangeException("Wrong index");
            }
            set
            {
                if ((row >= 0 && row < Size) && (column >= 0 && column < Size))
                {
                    if (row==column)
                    {
                    OnElementChanged(new ElementChangedEventArgs<T>(row, column, value,
                        body[row, column]));
                    body[row, column] = value;
                    }
                    else throw new ArgumentException("Can't change value");
                   
                }
                else
                throw new IndexOutOfRangeException("Wrong index");
            }
        }
    }
}
