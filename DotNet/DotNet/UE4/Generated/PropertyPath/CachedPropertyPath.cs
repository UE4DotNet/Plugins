// Copyright 2018 by JCoder58.  See License.txt for license
// Auto-generated --- Do not modify.
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using UE4.Core;
using UE4.CoreUObject;
using UE4.CoreUObject.Native;
using UE4.InputCore;
using UE4.Native;


namespace UE4.PropertyPath{
        ///<summary>Base class for cached property paths</summary>
        [StructLayout( LayoutKind.Explicit, Size=48 )]
        public unsafe struct CachedPropertyPath {
            [FieldOffset(0)] byte Segments; //TODO: array TArray Segments

            [FieldOffset(24)] 
            private IntPtr  CachedFunction_field;
            ///<summary>Cached function for function-terminated paths</summary>
            public Function CachedFunction {
                get {return CachedFunction_field;}
                set {CachedFunction_field = value;}
            }

        }
}
