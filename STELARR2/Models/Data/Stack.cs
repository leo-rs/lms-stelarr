using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace STELARR2.Models.Data
{
    public class Stack<T> : IEnumerable<T>
    {
        LinkedList<T> _stack = new LinkedList<T>();

        public void Push(T value)
        {
            _stack.AddFirst(value);
        }

        public T Pop()
        {
            if (_stack.Count == 0)
            {
                throw new InvalidOperationException("The stack is empty.");
            } 
            T value = _stack.First.Value;
            _stack.RemoveFirst();
            return value;
        }

        public T Peek()
        {
            if (_stack.Count == 0)
            {
                throw new InvalidOperationException("The stack is empty.");
            }
            return _stack.First.Value;
        }

        public void Clear()
        {
            _stack.Clear();
        }

        public IEnumerator<T> GetEnumerator()
        {
            return _stack.GetEnumerator();
        }
        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            return _stack.GetEnumerator();
        }

    }
}
