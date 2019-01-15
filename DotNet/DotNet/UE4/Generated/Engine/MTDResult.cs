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
        ///<summary>Structure containing information about minimum translation direction (MTD)</summary>
        [StructLayout( LayoutKind.Explicit, Size=16 )]
        public unsafe struct MTDResult {
            ///<summary>Normalized direction of the minimum translation required to fix penetration.</summary>
            [FieldOffset(0)] Vector Direction;

            [FieldOffset(12)] public float Distance;

        }
}
