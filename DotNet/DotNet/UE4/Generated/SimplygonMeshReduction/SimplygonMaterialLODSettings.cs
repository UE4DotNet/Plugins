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
        ///<summary>* Desc : The following class stores settings for the simplygon material LOD. Specifically the mapping image</summary>
        [StructLayout( LayoutKind.Explicit, Size=32 )]
        public unsafe struct SimplygonMaterialLODSettings {
            [FieldOffset(0)] public bool bActive;

            [FieldOffset(1)] public byte MaterialLODType;

            [FieldOffset(2)] public bool bUseAutomaticSizes;

            [FieldOffset(3)] public byte TextureWidth;

            [FieldOffset(4)] public byte TextureHeight;

            [FieldOffset(5)] public byte SamplingQuality;

            [FieldOffset(8)] public int GutterSpace;

            [FieldOffset(12)] public byte TextureStrech;

            [FieldOffset(13)] public bool bReuseExistingCharts;

            [FieldOffset(16)] byte ChannelsToCast; //TODO: array TArray ChannelsToCast

        }
}
