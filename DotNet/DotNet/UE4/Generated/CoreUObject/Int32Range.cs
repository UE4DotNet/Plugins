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


namespace UE4.CoreUObject{
        ///<summary>An int32 range</summary>
        [StructLayout( LayoutKind.Explicit, Size=16 )]
        public unsafe struct Int32Range {
            ///<summary>Lower Bound</summary>
            [FieldOffset(0)] Int32RangeBound LowerBound;

            ///<summary>Upper Bound</summary>
            [FieldOffset(8)] Int32RangeBound UpperBound;

        }
}
