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
    [StructLayout( LayoutKind.Explicit, Size=576 )]
    internal unsafe struct TextureRenderTarget2D_fields {
        [FieldOffset(528)] public int SizeX;
        [FieldOffset(532)] public int SizeY;
        [FieldOffset(536)] public LinearColor ClearColor;
        [FieldOffset(552)] public byte AddressX;
        [FieldOffset(553)] public byte AddressY;
        [FieldOffset(554)] public bool bForceLinearGamma;
        [FieldOffset(554)] public bool bGPUSharedFlag;
        [FieldOffset(554)] public bool bAutoGenerateMips;
        [FieldOffset(555)] public byte RenderTargetFormat;
        [FieldOffset(556)] public byte OverrideFormat;
    }
    internal unsafe struct TextureRenderTarget2D_methods {
    }
    internal unsafe struct TextureRenderTarget2D_events {
    }
}
