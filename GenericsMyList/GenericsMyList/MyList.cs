using System;
using System.Collections;

namespace GenericsMyList
{
    public class MyList<T> : ICollection 
    {
        private static readonly T[] EmptyArray = new T[0];
        private T[] _items;

        public MyList()
        {
            _items = EmptyArray;
        }

        public void Add(T item)
        {
            var tempArray = _items;
            _items = new T[tempArray.Length + 1];
            for (var i = 0; i < _items.Length; i++)
            {
                if (i == _items.Length-1)
                {
                    _items[i] = item;
                    continue;
                }
                _items[i] = tempArray[i];
            }
        }

        public IEnumerator GetEnumerator()
        {
            return _items.GetEnumerator();
        }

        public void CopyTo(Array array, int index)
        {
            throw new NotImplementedException();
        }

        public int Count => _items.Length;
        public object SyncRoot { get; }
        public bool IsSynchronized { get; }

        public T this[int index] => _items[index];
    }
}
