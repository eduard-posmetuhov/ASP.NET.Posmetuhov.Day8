using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatrixLib
{
    public class ElementChangedEventArgs<T>: EventArgs
    {
        public int Row { get; private set; }
        public int Column { get; private set; }
        public T OldValue { get; private set; }
        public T SetValue { get; private set; }


        public ElementChangedEventArgs(int row, int column, T setValue, T oldValue)
        {
            Row = row;
            Column = column;
            SetValue = setValue;
            OldValue = oldValue;
        }
    }
}
