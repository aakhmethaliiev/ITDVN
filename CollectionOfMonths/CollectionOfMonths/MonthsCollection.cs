using System;
using System.Collections;

namespace CollectionOfMonths
{
    /// <summary>
    /// Collection of months.
    /// </summary>
    public class MonthsCollection: IEnumerable, IEnumerator, IDisposable
    {
        /// <summary> Array of moths. </summary>
        private readonly Month[] _months = new Month[12];

        /// <summary> Default Constructor. </summary>
        public MonthsCollection()
        {
            _months[0] = new Month("January", 1, 31);
            _months[1] = new Month("February", 2, 28);
            _months[2] = new Month("March", 3, 31);
            _months[3] = new Month("April", 4, 30);
            _months[4] = new Month("May", 5, 31);
            _months[5] = new Month("June", 6, 30);
            _months[6] = new Month("July", 7, 31);
            _months[7] = new Month("August", 8, 31);
            _months[8] = new Month("September", 9, 30);
            _months[9] = new Month("October", 10, 31);
            _months[10] = new Month("November", 11, 30);
        }

        /// <summary> Month by index. </summary>
        /// <param name="index"> Index of month. </param>
        /// <returns> Month by index. </returns>
        public Month this[int index]
        {
            get => _months[index];
            set => _months[index] = value;
        }

        /// <summary> Position of indexator. </summary>
        private int _position = -1;

        /// <summary> Get enumerator. </summary>
        IEnumerator IEnumerable.GetEnumerator()
        {
            return this;
        }

        /// <summary> Move indexator to next position. </summary>
        /// <returns> Is it possible to move the indexer. </returns>
        public bool MoveNext()
        {
            if (_position >= _months.Length - 1)
            {
                return false;
            }

            _position++;
            return true;
        }

        /// <summary> Reset position to default value. </summary>
        public void Reset()
        {
            _position = -1;
        }

        /// <summary> Month by current position. </summary>
        object IEnumerator.Current { get; }

        /// <summary> Reset position. </summary>
        public void Dispose()
        {
            ((IEnumerator)this).Reset();
        }
    }
}