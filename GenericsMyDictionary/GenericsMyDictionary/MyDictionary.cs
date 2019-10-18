using System;

namespace GenericsMyDictionary
{
    public class MyDictionary<TKey, TValue>
    {
        private TKey[] _keys;
        private TValue[] _values;

        public MyDictionary()
        {
            _keys = new TKey[0];
            _values = new TValue[0];
        }

        public void Add(TKey key, TValue value)
        {
            var tempKeys = _keys;
            var tempValues = _values;
            _keys = new TKey[tempKeys.Length + 1];
            _values = new TValue[tempValues.Length + 1];
            for (var i = 0; i < _keys.Length; i++)
            {
                if (i == _keys.Length - 1)
                {
                    _keys[i] = key;
                    _values[i] = value;
                    continue;
                }

                _keys[i] = tempKeys[i];
                _values[i] = tempValues[i];
            }
        }

        public int Count => _keys.Length;

        public TValue this[TKey key]
        {
            get => _values[GetIndex(key)];
            set => Insert(key, value);
        }

        private int GetIndex(TKey key)
        {
            for (var i = 0; i < _keys.Length; i++)
            {
                if (key.GetHashCode() == _keys[i].GetHashCode()) return i;
            }

            return -1;
        }

        private void Insert(TKey key, TValue value)
        {
            _values[GetIndex(key)] = value;
        }
    }
}
