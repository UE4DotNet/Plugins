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
        ///<summary>Interp Control Point</summary>
        [StructLayout( LayoutKind.Explicit, Size=28 )]
        public unsafe struct InterpControlPoint {
            ///<summary>The position of the point</summary>
            [FieldOffset(0)] Vector PositionControlPoint;

            [FieldOffset(12)] public bool bPositionIsRelative;

        }
}
