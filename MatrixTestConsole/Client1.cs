using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MatrixLib;

namespace MatrixTestConsole
{
    public class Client1<T>
    {
        public Client1(SquareMatrix<T> matrix)
        {
            matrix.ElementChanged += OnElementChanged;
        }

        private void OnElementChanged(Object sender, ElementChangedEventArgs<T> eventArgs)
        {
            Console.WriteLine("Element[{0},{1}] was changed, Old value: {2}, New value: {3}", eventArgs.Row,
                eventArgs.Column, eventArgs.OldValue, eventArgs.SetValue, sender.GetType());
        }
    }
}
