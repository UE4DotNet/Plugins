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
        ///<summary>Overlay Line</summary>
        [StructLayout( LayoutKind.Explicit, Size=32 )]
        public unsafe struct OverlayLine {
            ///<summary>Start</summary>
            [FieldOffset(0)] Vector Start;

            ///<summary>End</summary>
            [FieldOffset(12)] Vector End;

            ///<summary>Color</summary>
            [FieldOffset(24)] Color Color;

            [FieldOffset(28)] public float Thickness;

        }
}
