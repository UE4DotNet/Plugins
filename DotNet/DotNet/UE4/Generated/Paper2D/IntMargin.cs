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


namespace UE4.Paper2D{
        ///<summary>Describes the space around a 2D area on an integer grid.</summary>
        [StructLayout( LayoutKind.Explicit, Size=16 )]
        public unsafe struct IntMargin {
            [FieldOffset(0)] public int Left;

            [FieldOffset(4)] public int Top;

            [FieldOffset(8)] public int Right;

            [FieldOffset(12)] public int Bottom;

        }
}
