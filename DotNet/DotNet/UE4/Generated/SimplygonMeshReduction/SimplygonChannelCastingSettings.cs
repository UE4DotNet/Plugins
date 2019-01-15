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


namespace UE4.SimplygonMeshReduction{
        ///<summary>* Desc : The following class stores settings for the simplygon caster.</summary>
        [StructLayout( LayoutKind.Explicit, Size=16 )]
        public unsafe struct SimplygonChannelCastingSettings {
            [FieldOffset(0)] public byte MaterialChannel;

            [FieldOffset(1)] public byte Caster;

            [FieldOffset(2)] public bool bActive;

            [FieldOffset(3)] public byte ColorChannels;

            [FieldOffset(4)] public int BitsPerChannel;

            [FieldOffset(8)] public bool bUseSRGB;

            [FieldOffset(9)] public bool bBakeVertexColors;

            [FieldOffset(10)] public bool bFlipBackfacingNormals;

            [FieldOffset(11)] public bool bUseTangentSpaceNormals;

            [FieldOffset(12)] public bool bFlipGreenChannel;

        }
}
