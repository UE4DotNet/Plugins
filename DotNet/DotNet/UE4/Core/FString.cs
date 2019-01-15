using System;
using System.Runtime.InteropServices;

namespace UE4.Core {
    [StructLayout( LayoutKind.Sequential )]
    internal struct FString {

        IntPtr Data;
        int ArrayCount;
        int ArrayMaxSize;
       
        public static unsafe string Get(byte* b) {
            if (b == null)
                return "";
            char* c = *(char**) b;
            int* cnt = (int*)(b + IntPtr.Size);
            if (c == null || *cnt <= 1)
                return "";
            return new string( c, 0, *cnt-1 );
        }

        public unsafe override string ToString() =>
            new String( (char*)Data.ToPointer(), 0, ArrayCount-1 );
    }
}
