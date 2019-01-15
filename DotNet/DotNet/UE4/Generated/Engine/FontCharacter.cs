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
        ///<summary>This struct is serialized using native serialization so any changes to it require a package version bump.</summary>
        [StructLayout( LayoutKind.Explicit, Size=24 )]
        public unsafe struct FontCharacter {
            [FieldOffset(0)] public int StartU;

            [FieldOffset(4)] public int StartV;

            [FieldOffset(8)] public int USize;

            [FieldOffset(12)] public int VSize;

            [FieldOffset(16)] public byte TextureIndex;

            [FieldOffset(20)] public int VerticalOffset;

        }
}
