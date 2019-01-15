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


namespace UE4.Engine{
        ///<summary>An exposed value updater</summary>
        [StructLayout( LayoutKind.Explicit, Size=48 )]
        public unsafe struct ExposedValueHandler {
            [FieldOffset(0)] public Name BoundFunction;

            [FieldOffset(16)] byte CopyRecords; //TODO: array TArray CopyRecords

            [FieldOffset(32)] 
            private IntPtr  Function_field;
            ///<summary>function pointer if BoundFunction != NAME_None</summary>
            public Function Function {
                get {return Function_field;}
                set {Function_field = value;}
            }

        }
}
