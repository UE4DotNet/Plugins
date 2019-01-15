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


namespace UE4.Engine{
        ///<summary>Film Stock Settings</summary>
        [StructLayout( LayoutKind.Explicit, Size=20 )]
        public unsafe struct FilmStockSettings {
            [FieldOffset(0)] public float Slope;

            [FieldOffset(4)] public float Toe;

            [FieldOffset(8)] public float Shoulder;

            [FieldOffset(12)] public float BlackClip;

            [FieldOffset(16)] public float WhiteClip;

        }
}
