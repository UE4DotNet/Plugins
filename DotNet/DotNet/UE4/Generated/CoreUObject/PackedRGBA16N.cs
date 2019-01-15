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
        ///<summary>A packed vector.</summary>
        ///<remarks>The full C++ class is located here: Engine\Source\Runtime\RenderCore\Public\PackedNormal.h</remarks>
        [StructLayout( LayoutKind.Explicit, Size=8 )]
        public unsafe struct PackedRGBA16N {
            [FieldOffset(0)] public int XY;

            [FieldOffset(4)] public int ZW;

        }
}
