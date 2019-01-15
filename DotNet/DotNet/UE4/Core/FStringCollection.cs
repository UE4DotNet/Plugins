using System;
using System.Collections;
using System.Collections.Generic;
using UE4.CoreUObject;

namespace UE4.Core {
    internal class FStringCollection : IReadOnlyCollection<string> {
        public int Count => ArrayCount;

        public unsafe FStringCollection( byte* pointerToArray ) {
            ArrayDataPtr = *(IntPtr*) pointerToArray;
            ArrayCount = *(int*) (pointerToArray + IntPtr.Size);
        }

        ~FStringCollection() {
            //TODO: Free array data for this TArray.
        }

        public IEnumerator<string> GetEnumerator() =>
            new EnumeratorT( this );

        IEnumerator IEnumerable.GetEnumerator() =>
            new EnumeratorT( this );

        IntPtr ArrayDataPtr;
        int ArrayCount;

        private class EnumeratorT : IEnumerator<string> {
            public EnumeratorT( FStringCollection over ) {
                Over = over;
            }

            FStringCollection Over;
            int Next = -1;

            public string Current { get; private set; }

            object IEnumerator.Current => Current;

            public bool MoveNext() {
                if (++Next < Over.ArrayCount) {
                    unsafe {
                        FString* data = (FString*) Over.ArrayDataPtr.ToPointer();
                        Current = data[Next].ToString();
                        return true;
                    }
                }
                return false;
            }

            public void Reset() {
                Next = -1;
                Current = "";
            }

            public void Dispose() {
                Reset();
                Over = null;
            }
        }

    }
}
