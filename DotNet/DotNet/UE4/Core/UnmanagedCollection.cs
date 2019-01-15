using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace UE4.Core {
    internal class UnmanagedCollection<T> : IReadOnlyCollection<T> where T:unmanaged {
        public int Count => ArrayCount;

        public unsafe UnmanagedCollection( byte* pointerToArray ) {
            ArrayDataPtr = *(IntPtr*) pointerToArray;
            ArrayCount = *(int*) (pointerToArray + IntPtr.Size);
        }

        ~UnmanagedCollection() {
            //TODO: Free array data for this TArray.
        }

        public IEnumerator<T> GetEnumerator() =>
            new EnumeratorT( this );

        IEnumerator IEnumerable.GetEnumerator() =>
            new EnumeratorT( this );

        IntPtr ArrayDataPtr;
        int ArrayCount;

        private class EnumeratorT : IEnumerator<T> {
            public EnumeratorT( UnmanagedCollection<T> over ) {
                Over = over;
            }

            UnmanagedCollection<T> Over;
            int Next = -1;

            public T Current { get; private set; }

            object IEnumerator.Current => Current;

            public bool MoveNext() {
                if (++Next < Over.ArrayCount) {
                    unsafe {
                        int size = sizeof(T);
                        T* data = (T*) Over.ArrayDataPtr.ToPointer();
                        Current = *data;
                        return true;
                    }
                }
                return false;
            }

            public void Reset() {
                Next = -1;
                Current = default(T);
            }

            public void Dispose() {
                Reset();
                Over = null;
            }
        }

    }
}
