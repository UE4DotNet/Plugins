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
        ///<summary>Event Graph Fast Call Pair</summary>
        [StructLayout( LayoutKind.Explicit, Size=16 )]
        public unsafe struct EventGraphFastCallPair {
            [FieldOffset(0)] 
            private IntPtr  FunctionToPatch_field;
            ///<summary>Function to Patch</summary>
            public Function FunctionToPatch {
                get {return FunctionToPatch_field;}
                set {FunctionToPatch_field = value;}
            }

            [FieldOffset(8)] public int EventGraphCallOffset;

        }
}
