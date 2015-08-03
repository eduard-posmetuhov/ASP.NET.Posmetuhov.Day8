using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatrixLib
{
    public class SymmetricalMatrix<T> : SquareMatrix<T>
    {
        public SymmetricalMatrix(T[,] sourse)
            :base(sourse)
        {            
            for (int i = 0; i < Size; i++)
                for (int j = 0; j < Size; j++)
                    if (!sourse[i, j].Equals(sourse[j, i]))
                        throw new ArgumentException("Matrix is not symmetrical");                    
        }
        

        public SymmetricalMatrix(int size)
            : base(size)
        {            
        }

        public override T this[int row, int column]
        {
            get
            {
                if ((row >= 0 && row <= Size) && (column >= 0 && column < Size))
                    return body[row, column];
                throw new IndexOutOfRangeException("Wrong index");
            }
            set
            {
                if ((row >= 0 && row < Size) && (column >= 0 && column < Size))
                {
                    OnElementChanged(new ElementChangedEventArgs<T>(row, column, value,
                        body[row, column]));
                    body[row, column] = value;
                    OnElementChanged(new ElementChangedEventArgs<T>(column, row, value,
                        body[column, row]));
                    body[column, row] = value;
                }
                else
                throw new IndexOutOfRangeException("Wrong index");
            }
        }
    }
}
