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
        ///<summary>A single entry in a typeface</summary>
        [StructLayout( LayoutKind.Explicit, Size=72 )]
        public unsafe struct TypefaceEntry {
            [FieldOffset(0)] public Name Name;

            ///<summary>Raw font data for this font</summary>
            [FieldOffset(16)] FontData Font;

        }
}
