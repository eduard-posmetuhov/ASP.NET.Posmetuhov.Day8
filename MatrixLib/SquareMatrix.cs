using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatrixLib
{
    public class SquareMatrix<T>
    {
        protected T[,] body;
        public event EventHandler<ElementChangedEventArgs<T>> ElementChanged = delegate { };

        public SquareMatrix(T[,] sourse)
        {
            if (sourse.GetLength(0) != sourse.GetLength(1))
                throw new ArgumentException("Matrix is not square");
            body = sourse;
        }

        public SquareMatrix(int size)
        {
            if (size <= 0)
                throw new ArgumentException("Wrong matrix size");
            body = new T[size, size];
        }

        public int Size
        { get { return body.GetLength(0); } }

        public virtual T this[int row, int column]
        {
            get
            {
                if ((row >= 0 && row < Size) && (column >= 0 && column < Size))
                return body[row,column];
                throw new IndexOutOfRangeException("Wrong index");
            }
            set
            {
                if ((row >= 0 && row < Size) && (column >= 0 && column < Size))
                {
                    OnElementChanged(new ElementChangedEventArgs<T>(row, column, value,
                        body[row, column]));
                    body[row, column] = value;
                }
                else
                throw new IndexOutOfRangeException("Wrong index");
            }
        }

        protected void OnElementChanged(ElementChangedEventArgs<T> e)
        {
            ElementChanged(this, e);
        }
    }
}
