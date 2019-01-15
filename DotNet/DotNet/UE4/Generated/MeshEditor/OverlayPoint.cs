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


namespace UE4.MeshEditor{
        ///<summary>Overlay Point</summary>
        [StructLayout( LayoutKind.Explicit, Size=20 )]
        public unsafe struct OverlayPoint {
            ///<summary>Position</summary>
            [FieldOffset(0)] Vector Position;

            ///<summary>Color</summary>
            [FieldOffset(12)] Color Color;

            [FieldOffset(16)] public float Size;

        }
}
