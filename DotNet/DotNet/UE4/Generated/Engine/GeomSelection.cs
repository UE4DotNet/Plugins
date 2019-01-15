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
        ///<summary>Selection information for geometry mode</summary>
        [StructLayout( LayoutKind.Explicit, Size=12 )]
        public unsafe struct GeomSelection {
            [FieldOffset(0)] public int Type;

            [FieldOffset(4)] public int Index;

            [FieldOffset(8)] public int SelectionIndex;

        }
}
