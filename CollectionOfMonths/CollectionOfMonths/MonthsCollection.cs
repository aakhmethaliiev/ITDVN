using System;
using System.Collections;
using System.Collections.Generic;

namespace CollectionOfMonths
{
    /// <summary>
    /// Collection of months.
    /// </summary>
    public class MonthsCollection<T>: IEnumerable<T>, IEnumerator<T>, IDisposable
    {
        /// <summary> Array of moths. </summary>
        private readonly T[] _months = new T[12];

        ///// <summary> Default Constructor. </summary>
        public MonthsCollection()
        {
            
        }

        /// <summary> Month by index. </summary>
        /// <param name="index"> Index of month. </param>
        /// <returns> Month by index. </returns>
        public T this[int index]
        {
            get => _months[index];
            set => _months[index] = value;
        }

        /// <summary> Position of indexator. </summary>
        int _position = -1;

        public IEnumerator<T> GetEnumerator()
        {
            return this;
        }

        /// <summary> Get enumerator. </summary>
        IEnumerator IEnumerable.GetEnumerator()
        {
            return this;
        }

        /// <summary> Move indexator to next position. </summary>
        /// <returns> Is it possible to move the indexer. </returns>
        bool IEnumerator.MoveNext()
        {
            if (_position >= _months.Length - 1)
            {
                return false;
            }

            _position++;
            return true;
        }

        /// <summary> Reset position to default value. </summary>
        void IEnumerator.Reset()
        {
            _position = -1;
        }

        public object Current { get; }

        /// <summary> Month by current position. </summary>
        T IEnumerator<T>.Current => _months[_position];

        /// <summary> Reset position. </summary>
        void IDisposable.Dispose()
        {
            ((IEnumerator)this).Reset();
        }
    }
}