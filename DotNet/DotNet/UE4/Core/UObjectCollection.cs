using System;
using System.Collections;
using System.Collections.Generic;
using UE4.CoreUObject;

namespace UE4.Core {
    internal class UObjectCollection<T> : IReadOnlyCollection<T> where T : UObject, new() {
        public int Count => ArrayCount;

        public unsafe UObjectCollection(byte* pointerToArray) {
            ArrayDataPtr = *(IntPtr*) pointerToArray;
            ArrayCount = *(int*) (pointerToArray + IntPtr.Size);
        }

        ~UObjectCollection() {
            //TODO: Free array data for this TArray.
        }

        public IEnumerator<T> GetEnumerator() =>
            new EnumeratorT( this);

        IEnumerator IEnumerable.GetEnumerator() =>
            new EnumeratorT( this );

        IntPtr ArrayDataPtr;
        int ArrayCount;

        private class EnumeratorT : IEnumerator<T> {
            public EnumeratorT( UObjectCollection<T> over ) {
                Over = over;
            }

            UObjectCollection<T> Over;
            int Next = -1;

            public T Current { get; private set; }

            object IEnumerator.Current => Current;

            public bool MoveNext() {
                if (++Next < Over.ArrayCount) {
                    unsafe {
                        IntPtr* data = (IntPtr*) Over.ArrayDataPtr.ToPointer();
                        Current = UObject.Make<T>( data[Next] );
                        return true;
                    }
                }
                return false;
            }

            public void Reset() {
                Next = -1;
                Current = null;
            }

            public void Dispose() {
                Reset();
                Over = null;
            }
        }

    }
}
