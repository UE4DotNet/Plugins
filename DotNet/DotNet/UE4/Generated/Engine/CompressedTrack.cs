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
        ///<summary>Compressed Track</summary>
        [StructLayout( LayoutKind.Explicit, Size=56 )]
        public unsafe struct CompressedTrack {
            [FieldOffset(0)] byte ByteStream; //TODO: array TArray ByteStream

            [FieldOffset(16)] byte Times; //TODO: array TArray Times

            [FieldOffset(32)] public float Mins;

            [FieldOffset(44)] public float Ranges;

        }
}
