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


namespace UE4.SlateCore{
        ///<summary>Composite Fallback Font</summary>
        [StructLayout( LayoutKind.Explicit, Size=24 )]
        public unsafe struct CompositeFallbackFont {
            ///<summary>Typeface data for this sub-font</summary>
            [FieldOffset(0)] Typeface Typeface;

            [FieldOffset(16)] public float ScalingFactor;

        }
}
