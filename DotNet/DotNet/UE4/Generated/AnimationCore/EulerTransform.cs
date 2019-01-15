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


namespace UE4.AnimationCore{
        ///<summary>Euler Transform</summary>
        [StructLayout( LayoutKind.Explicit, Size=36 )]
        public unsafe struct EulerTransform {
            ///<summary>The translation of this transform</summary>
            [FieldOffset(0)] Vector Location;

            ///<summary>The rotation of this transform</summary>
            [FieldOffset(12)] Rotator Rotation;

            ///<summary>The scale of this transform</summary>
            [FieldOffset(24)] Vector Scale;

        }
}
