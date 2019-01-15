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
        ///<summary>Sound Group</summary>
        [StructLayout( LayoutKind.Explicit, Size=32 )]
        public unsafe struct SoundGroup {
            [FieldOffset(0)] public byte SoundGroup_;

            [FieldOffset(8)] byte DisplayName; //TODO: string FString DisplayName

            [FieldOffset(24)] public bool bAlwaysDecompressOnLoad;

            [FieldOffset(28)] public float DecompressedDuration;

        }
}
