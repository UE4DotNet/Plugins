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
        ///<summary>Hardware Cursor Reference</summary>
        [StructLayout( LayoutKind.Explicit, Size=20 )]
        public unsafe struct HardwareCursorReference {
            [FieldOffset(0)] public Name CursorPath;

            ///<summary>HotSpot needs to be in normalized (0.</summary>
            ///<remarks>
            ///.1) coordinates since it may apply to different resolution images.
            ///NOTE: This HotSpot is only used on formats that do not provide their own hotspot, e.g. Tiff, PNG.
            ///</remarks>
            [FieldOffset(12)] Vector2D HotSpot;

        }
}
