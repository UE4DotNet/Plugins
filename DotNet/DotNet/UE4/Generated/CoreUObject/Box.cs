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
        ///<summary>A bounding box.</summary>
        ///<remarks>The full C++ class is located here: Engine\Source\Runtime\Core\Public\Math\Box.h</remarks>
        [StructLayout( LayoutKind.Explicit, Size=28 )]
        public unsafe struct Box {
            ///<summary>Min</summary>
            [FieldOffset(0)] Vector Min;

            ///<summary>Max</summary>
            [FieldOffset(12)] Vector Max;

            [FieldOffset(24)] public byte IsValid;

        }
}
