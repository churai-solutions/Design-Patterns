using System;
using System.Collections;
using System.Collections.Generic;

namespace Patterns.Behavioral.Iterator
{
    public sealed class EnumerableDataSource : IEnumerable<string>
    {
        private readonly string[] _internalSource;

        public EnumerableDataSource(string[] data)
        {
            _internalSource = data;
        }

        public IEnumerator<string> GetEnumerator()
        {
            return new EnumerableDataSourceEnumerator(this);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        public sealed class EnumerableDataSourceEnumerator : IEnumerator<string>
        {
            private readonly EnumerableDataSource _enumerableDataSource;
            private int _actualIndex = -1;

            public EnumerableDataSourceEnumerator(EnumerableDataSource enumerableDataSource)
            {
                _enumerableDataSource = enumerableDataSource;
            }

            public void Dispose()
            {
                
            }

            public bool MoveNext()
            {
                _actualIndex++;
                return (_actualIndex < _enumerableDataSource._internalSource.Length);
            }

            public void Reset()
            {
                _actualIndex = -1;
            }

            public string Current
            {
                get
                {
                    try
                    {
                        return _enumerableDataSource._internalSource[_actualIndex];
                    }
                    catch (IndexOutOfRangeException indexOutOfRangeException)
                    {
                        Console.WriteLine(indexOutOfRangeException);
                        throw new InvalidOperationException(indexOutOfRangeException.Message);
                    }
                }
            }

            object IEnumerator.Current => Current;
        }
    }
}
