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
        ///<summary>Cached vertex information at the time the mesh was painted.</summary>
        [StructLayout( LayoutKind.Explicit, Size=48 )]
        public unsafe struct PaintedVertex {
            ///<summary>Position</summary>
            [FieldOffset(0)] Vector Position;

            ///<summary>Normal</summary>
            [FieldOffset(16)] Vector4 Normal;

            ///<summary>Color</summary>
            [FieldOffset(32)] Color Color;

        }
}
