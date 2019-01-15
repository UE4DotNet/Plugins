using System;
using System.Collections;
using System.Collections.Generic;

using UE4.CoreUObject;

namespace UE4.Core {

    //TODO: Need ArraySource for struct/class arrays

    public class TArray<T> : IList<T>,IEquatable<TArray<T>> {

        public static TArray<T> MakeTArray( IntPtr arrayData ) {
            if (typeof( T ).IsSubclassOf( typeof(UObject))) {
                var copyArray = new CopyArrayUObject<T>(arrayData);
                return new TArray<T>( copyArray );
            }
            throw new NotImplementedException();
        }


        public int IndexOf( T item ) {
            for (var i = 0; i < Count; i++)
                if (this[i].Equals( item ))
                    return i;
            return -1;
        }

        public void Insert( int index, T item ) {
            throw new NotImplementedException();
        }

        public void RemoveAt( int index ) {
            throw new NotImplementedException();
        }

        public void Add( T item ) {
            throw new NotImplementedException();
        }

        public void Clear() {
            throw new NotImplementedException();
        }

        public bool Contains( T item ) {
            foreach (var i in this)
                if (i.Equals(item))
                    return true;
            return false;
        }

        public void CopyTo( T[] array, int arrayIndex ) {
            for (var i = arrayIndex; i < Count; i++)
                array[i] = this[i];
        }

        public bool Remove( T item ) {
            throw new NotImplementedException();
        }

        private class ArrayEnumerator<T> : IEnumerator<T> {
            public ArrayEnumerator( ArraySource<T> source ) {
                Source = source;
            }

            public T Current => Source.Get( Next );

            object IEnumerator.Current => Source.Get( Next );

            public void Dispose() {}

            public bool MoveNext() {
                if (++Next < Source.Count)
                    return true;
                return false;
            }

            public void Reset() {
                Next = -1;
            }

            int Next = -1;
            ArraySource<T> Source;
        }

        public IEnumerator<T> GetEnumerator() =>
            new ArrayEnumerator<T>( ArrayData );

        IEnumerator IEnumerable.GetEnumerator() {
            throw new NotImplementedException();
        }

        public bool Equals( TArray<T> other ) =>
            ArrayData == other.ArrayData;

        public override int GetHashCode() => ArrayData.GetHashCode();

        private TArray( ArraySource<T> arrayData) {
            ArrayData = arrayData;
        }

        public int Count => ArrayData.Count;

        public bool IsReadOnly => ArrayData.IsReadOnly;

        public T this[int index] {
            get => ArrayData.Get(index);
            set => ArrayData.Set(index, value);
        }

        ArraySource<T> ArrayData;
    }

    internal interface ArraySource<T> {
        T Get( int index );
        bool IsReadOnly { get; }
        void Set( int index, T value );
        int Count { get; }
    }

    abstract class CopyArray<T> : ArraySource<T>, IEquatable<CopyArray<T>> {
        public unsafe CopyArray( IntPtr arrayPtr ) {
            IntPtr* ap = (IntPtr*) arrayPtr.ToPointer();
            ArrayData = *ap;
            ArrayCount = *(int*) (ap + 1);
        }

        ~CopyArray() {
            //TODO: Free array memory to UE4
        }

        public bool IsReadOnly => false;

        public abstract T Get( int index );

        public abstract void Set( int index, T value );

        public bool Equals( CopyArray<T> other ) =>
            ArrayData == other.ArrayData;

        public override int GetHashCode() =>
            ArrayData.GetHashCode();

        public int Count => ArrayCount;

        protected IntPtr ArrayData;
        protected int ArrayCount;
    }

    class CopyArrayUObject<T> : CopyArray<T> {
        public unsafe CopyArrayUObject( IntPtr arrayPtr ) : base( arrayPtr ) { }

        public override unsafe T Get( int index ) {
            if (index < 0 || index >= ArrayCount)
                throw new IndexOutOfRangeException();
            IntPtr pointer = IntPtr.Add(ArrayData, index * sizeof(IntPtr));
            UObject obj = UObject.Make(pointer, typeof(T));
            //return UObject.CastTo<T>( obj );
            throw new NotImplementedException();
        }

        public override void Set( int index, T value ) {
            throw new NotImplementedException();
        }
    }
}
