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


namespace UE4.PIEPreviewDeviceSpecification{
        ///<summary>PIERHIOverride State</summary>
        [StructLayout( LayoutKind.Explicit, Size=20 )]
        public unsafe struct PIERHIOverrideState {
            [FieldOffset(0)] public int MaxShadowDepthBufferSizeX;

            [FieldOffset(4)] public int MaxShadowDepthBufferSizeY;

            [FieldOffset(8)] public int MaxTextureDimensions;

            [FieldOffset(12)] public int MaxCubeTextureDimensions;

            [FieldOffset(16)] public bool SupportsRenderTargetFormat_PF_G8;

            [FieldOffset(17)] public bool SupportsRenderTargetFormat_PF_FloatRGBA;

            [FieldOffset(18)] public bool SupportsMultipleRenderTargets;

            [FieldOffset(19)] public bool SupportsInstancing;

        }
}
