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
        ///<summary>An orthogonal rotation in 3d space.</summary>
        ///<remarks>The full C++ class is located here: Engine\Source\Runtime\Core\Public\Math\Rotator.h</remarks>
        [StructLayout( LayoutKind.Explicit, Size=12 )]
        public unsafe struct Rotator {
            [FieldOffset(0)] public float Pitch;

            [FieldOffset(4)] public float Yaw;

            [FieldOffset(8)] public float Roll;

        }
}
