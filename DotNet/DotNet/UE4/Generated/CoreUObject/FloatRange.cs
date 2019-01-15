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
        ///<summary>A float range</summary>
        [StructLayout( LayoutKind.Explicit, Size=16 )]
        public unsafe struct FloatRange {
            ///<summary>Lower Bound</summary>
            [FieldOffset(0)] FloatRangeBound LowerBound;

            ///<summary>Upper Bound</summary>
            [FieldOffset(8)] FloatRangeBound UpperBound;

        }
}
