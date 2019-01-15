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
        ///<summary>A representation of a font in Slate.</summary>
        [StructLayout( LayoutKind.Explicit, Size=104 )]
        public unsafe struct SlateFontInfo {
            [FieldOffset(0)] 
            private IntPtr  FontObject_field;
            ///<summary>The font object (valid when used from UMG or a Slate widget style asset)</summary>
            public UObject FontObject {
                get {return FontObject_field;}
                set {FontObject_field = value;}
            }

            [FieldOffset(8)] 
            private IntPtr  FontMaterial_field;
            ///<summary>The material to use when rendering this font</summary>
            public UObject FontMaterial {
                get {return FontMaterial_field;}
                set {FontMaterial_field = value;}
            }

            ///<summary>Settings for applying an outline to a font</summary>
            [FieldOffset(16)] FontOutlineSettings OutlineSettings;

            [FieldOffset(64)] public Name TypefaceFontName;

            [FieldOffset(76)] public int Size;

        }
}
