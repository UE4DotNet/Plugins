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
        ///<summary>Capsule shape used for collision. Z axis is capsule axis. Has a start and end radius that can differ.</summary>
        [StructLayout( LayoutKind.Explicit, Size=88 )]
        public unsafe struct KTaperedCapsuleElem {
            ///<summary>Position of the capsule's origin</summary>
            [FieldOffset(48)] Vector Center;

            ///<summary>Rotation of the capsule</summary>
            [FieldOffset(60)] Rotator Rotation;

            [FieldOffset(72)] public float Radius0;

            [FieldOffset(76)] public float Radius1;

            [FieldOffset(80)] public float Length;

        }
}
