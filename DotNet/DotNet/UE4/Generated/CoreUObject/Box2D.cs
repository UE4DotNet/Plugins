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
        ///<summary>A rectangular 2D Box.</summary>
        ///<remarks>The full C++ class is located here: Engine\Source\Runtime\Core\Public\Math\Box2D.h</remarks>
        [StructLayout( LayoutKind.Explicit, Size=20 )]
        public unsafe struct Box2D {
            ///<summary>Min</summary>
            [FieldOffset(0)] Vector2D Min;

            ///<summary>Max</summary>
            [FieldOffset(8)] Vector2D Max;

            [FieldOffset(16)] public byte bIsValid;

        }
}
