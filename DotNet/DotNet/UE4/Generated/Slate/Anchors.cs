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


namespace UE4.Slate{
        ///<summary>Describes how a widget is anchored.</summary>
        [StructLayout( LayoutKind.Explicit, Size=16 )]
        public unsafe struct Anchors {
            ///<summary>Holds the minimum anchors, left + top.</summary>
            [FieldOffset(0)] Vector2D Minimum;

            ///<summary>Holds the maximum anchors, right + bottom.</summary>
            [FieldOffset(8)] Vector2D Maximum;

        }
}
