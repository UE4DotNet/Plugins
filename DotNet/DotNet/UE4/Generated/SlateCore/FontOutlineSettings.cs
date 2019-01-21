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
        ///<summary>Settings for applying an outline to a font</summary>
        [StructLayout( LayoutKind.Explicit, Size=40 )]
        public unsafe struct FontOutlineSettings {
            [FieldOffset(0)] public int OutlineSize;

            [FieldOffset(8)] 
            private IntPtr  OutlineMaterial_field;
            ///<summary>Optional material to apply to the outline</summary>
            public UObject OutlineMaterial {
                get {return OutlineMaterial_field;}
                set {OutlineMaterial_field = value;}
            }

            ///<summary>The color of the outline for any character in this font</summary>
            [FieldOffset(16)] LinearColor OutlineColor;

            [FieldOffset(32)] public bool bSeparateFillAlpha;

            [FieldOffset(32)] public bool bApplyOutlineToDropShadows;

        }
}
