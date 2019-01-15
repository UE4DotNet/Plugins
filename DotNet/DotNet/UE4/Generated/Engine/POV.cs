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
        ///<summary>Point Of View type.</summary>
        [StructLayout( LayoutKind.Explicit, Size=28 )]
        public unsafe struct POV {
            ///<summary>Location</summary>
            [FieldOffset(0)] Vector Location;

            ///<summary>Rotation</summary>
            [FieldOffset(12)] Rotator Rotation;

            [FieldOffset(24)] public float FOV;

        }
}
