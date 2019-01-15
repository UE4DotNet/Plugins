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
        ///<summary>A bounding box and bounding sphere with the same origin.</summary>
        ///<remarks>The full C++ class is located here : Engine\Source\Runtime\Core\Public\Math\BoxSphereBounds.h</remarks>
        [StructLayout( LayoutKind.Explicit, Size=28 )]
        public unsafe struct BoxSphereBounds {
            ///<summary>Origin</summary>
            [FieldOffset(0)] Vector Origin;

            ///<summary>Box Extent</summary>
            [FieldOffset(12)] Vector BoxExtent;

            [FieldOffset(24)] public float SphereRadius;

        }
}
