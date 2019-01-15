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
        ///<summary>A rich, editable float curve</summary>
        [StructLayout( LayoutKind.Explicit, Size=112 )]
        public unsafe struct RichCurve {
            [FieldOffset(88)] public byte PreInfinityExtrap;

            [FieldOffset(89)] public byte PostInfinityExtrap;

            [FieldOffset(92)] public float DefaultValue;

            [FieldOffset(96)] byte Keys; //TODO: array TArray Keys

        }
}
