using System;
using System.Runtime.InteropServices;

namespace UE4.Core {
    [StructLayout( LayoutKind.Sequential )]
    public struct NativeArray {

        public IntPtr Data;
        public int ArrayCount;
        public int ArrayMaxSize;
    }
}
