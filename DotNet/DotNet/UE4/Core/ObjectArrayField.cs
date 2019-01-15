using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Text;

using UE4.CoreUObject;
using UE4.Native;

namespace UE4.Core {
    internal delegate void AddDelegate( IntPtr Array, IntPtr Object );
    internal delegate void RemoveAtDelegate( IntPtr Array, int index );
    internal delegate void InsertDelegate( IntPtr Array, IntPtr Object, int index );
    internal delegate void ReserveDelegate( IntPtr Array, int ReserveSize );

    public class ObjectArrayField<T> : IList<T> where T : UObject, new() {
        private unsafe NativeArray* Array;

        private unsafe IntPtr* Data => (IntPtr*) Array->Data.ToPointer();
        private unsafe int NativeCount => Array->ArrayCount;

        internal unsafe ObjectArrayField(NativeArray* array) {
            Array = array;
        }

        public unsafe T this[int index] {
            get {
                if (index < 0 || index >= Array->ArrayCount)
                    throw new IndexOutOfRangeException();
                return UObject.Make<T>( Data[index] );
            }
            set {
                if (index < 0 || index >= Array->ArrayCount)
                    throw new IndexOutOfRangeException();
                Data[index] = value;
            }
        }

        public int Count => NativeCount;

        public bool IsReadOnly => false;

        public unsafe void Add( T item ) {
            if (Array->ArrayCount >= Array->ArrayMaxSize)
                Local.Add( new IntPtr( Array ), item );
            else {
                int newIndex = Array->ArrayCount++;
                Data[newIndex] = item;
            }
        }
        

        public unsafe void Clear() {
            Array->ArrayCount = 0;
        }

        public bool Contains( T item ) =>
            IndexOf( item ) >= 0;

        public IEnumerator<T> GetEnumerator() {
            for (int i = 0; i < Count; i++)
                yield return this[i];
        }

        public unsafe int IndexOf( T item ) {
            var objPointer = item.ObjPointer;
            for (int i = 0; i < Count; i++)
                if (Data[i] == objPointer)
                    return i;
            return -1;
        }

        IEnumerator IEnumerable.GetEnumerator() {
            for (int i = 0; i < Count; i++)
                yield return this[i];
        }

        public void CopyTo( T[] array, int arrayIndex ) {
            //TODO: ArrayField CopyTo
            throw new NotImplementedException();
        }

        public unsafe void Insert( int index, T item ) {
            Local.Insert( new IntPtr( Array ), item, index );
        }

        public bool Remove( T item ) {
            int i = IndexOf(item);
            if (i < 0)
                return false;
            RemoveAt( i );
            return true;
        }

        public unsafe void RemoveAt( int index ) {
            Local.RemoveAt( new IntPtr( Array ), index );
        }

        public unsafe void Reserve(int size) {
            Local.Reserve( new IntPtr( Array ), size );
        }

        private unsafe struct Local {
            public static ObjectArrayNative* NativeFunctions;

            public static AddDelegate Add;
            public static RemoveAtDelegate RemoveAt;
            public static InsertDelegate Insert;
            public static ReserveDelegate Reserve;

            static Local() {
                NativeFunctions = (ObjectArrayNative*) Interfaces.Get( Core.Name.Make( "PointerArray" ) ).ToPointer();
                Debug.Assert( NativeFunctions != null );
                NativeFunctions->Validate();
                Add = Marshal.GetDelegateForFunctionPointer<AddDelegate>( NativeFunctions->Add );
                RemoveAt = Marshal.GetDelegateForFunctionPointer<RemoveAtDelegate>( NativeFunctions->RemoveAt );
                Insert = Marshal.GetDelegateForFunctionPointer<InsertDelegate>( NativeFunctions->Insert );
                Reserve = Marshal.GetDelegateForFunctionPointer<ReserveDelegate>( NativeFunctions->Reserve );
            }
        }
    }

    [StructLayout( LayoutKind.Sequential, Pack = 0 )]
    internal struct ObjectArrayNative {
        uint StartGuardian;
        uint SizeOfShared;
        int FNameID;

        internal IntPtr Add;
        internal IntPtr RemoveAt;
        internal IntPtr Insert;
        internal IntPtr Reserve;

        uint EndGuardian;

        public void Validate() {
            var size = Marshal.SizeOf<UObjectNative>();
            Debug.Assert( StartGuardian == 0x12345678 &&
                EndGuardian == 0x87654321 &&
                SizeOfShared == size
                );
        }
    }

}
