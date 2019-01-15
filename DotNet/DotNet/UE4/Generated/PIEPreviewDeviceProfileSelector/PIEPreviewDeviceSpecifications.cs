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


namespace UE4.PIEPreviewDeviceProfileSelector{
        ///<summary>PIEPreview Device Specifications</summary>
        [StructLayout( LayoutKind.Explicit, Size=232 )]
        public unsafe struct PIEPreviewDeviceSpecifications {
            [FieldOffset(0)] byte DevicePlatform; //TODO: enum EPIEPreviewDeviceType DevicePlatform

            [FieldOffset(4)] public int ResolutionX;

            [FieldOffset(8)] public int ResolutionY;

            [FieldOffset(12)] public int ResolutionYImmersiveMode;

            ///<summary>Android Properties</summary>
            [FieldOffset(16)] PIEAndroidDeviceProperties AndroidProperties;

            ///<summary>IOSProperties</summary>
            [FieldOffset(160)] PIEIOSDeviceProperties IOSProperties;

            ///<summary>Bezel Viewport Rect</summary>
            [FieldOffset(216)] PIEPreviewDeviceBezelViewportRect BezelViewportRect;

        }
}
