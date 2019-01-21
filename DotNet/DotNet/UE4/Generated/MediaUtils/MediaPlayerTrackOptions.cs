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


namespace UE4.MediaUtils{
        ///<summary>Media Player Track Options</summary>
        [StructLayout( LayoutKind.Explicit, Size=28 )]
        public unsafe struct MediaPlayerTrackOptions {
            [FieldOffset(0)] public int Audio;

            [FieldOffset(4)] public int Caption;

            [FieldOffset(8)] public int Metadata;

            [FieldOffset(12)] public int Script;

            [FieldOffset(16)] public int Subtitle;

            [FieldOffset(20)] public int Text;

            [FieldOffset(24)] public int Video;

        }
}
