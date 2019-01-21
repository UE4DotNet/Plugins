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


namespace UE4.Engine.Native {
    [StructLayout( LayoutKind.Explicit, Size=560 )]
    internal unsafe struct TextureRenderTarget2D_fields {
        [FieldOffset(520)] public int SizeX;
        [FieldOffset(524)] public int SizeY;
        [FieldOffset(528)] public LinearColor ClearColor;
        [FieldOffset(544)] public byte AddressX;
        [FieldOffset(545)] public byte AddressY;
        [FieldOffset(546)] public bool bForceLinearGamma;
        [FieldOffset(546)] public bool bGPUSharedFlag;
        [FieldOffset(546)] public bool bAutoGenerateMips;
        [FieldOffset(547)] public byte RenderTargetFormat;
        [FieldOffset(548)] public byte OverrideFormat;
    }
    internal unsafe struct TextureRenderTarget2D_methods {
    }
    internal unsafe struct TextureRenderTarget2D_events {
    }
}
