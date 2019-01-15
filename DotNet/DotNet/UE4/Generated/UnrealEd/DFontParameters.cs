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

using UE4.Engine;

namespace UE4.UnrealEd{
        ///<summary>DFont Parameters</summary>
        [StructLayout( LayoutKind.Explicit, Size=16 )]
        public unsafe struct DFontParameters {
            [FieldOffset(0)] 
            private IntPtr  FontValue_field;
            ///<summary>Font Value</summary>
            public Font FontValue {
                get {return FontValue_field;}
                set {FontValue_field = value;}
            }

            [FieldOffset(8)] public int FontPage;

        }
}
