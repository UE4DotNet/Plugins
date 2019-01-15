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
        ///<summary>A Slate color can be a directly specified value, or the color can be pulled from a WidgetStyle.</summary>
        [StructLayout( LayoutKind.Explicit, Size=40 )]
        public unsafe struct SlateColor {
            ///<summary>The current specified color; only meaningful when ColorToUse == UseColor_Specified.</summary>
            [FieldOffset(0)] LinearColor SpecifiedColor;

            [FieldOffset(16)] public byte ColorUseRule;

        }
}
