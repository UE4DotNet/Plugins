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
        ///<summary>PIEPreview Device Specifications</summary>
        [StructLayout( LayoutKind.Explicit, Size=296 )]
        public unsafe struct PIEPreviewDeviceSpecifications {
            [FieldOffset(0)] byte DevicePlatform; //TODO: enum EPIEPreviewDeviceType DevicePlatform

            [FieldOffset(4)] public int ResolutionX;

            [FieldOffset(8)] public int ResolutionY;

            [FieldOffset(12)] public int ResolutionYImmersiveMode;

            [FieldOffset(16)] public int PPI;

            [FieldOffset(24)] byte ScaleFactors; //TODO: array TArray ScaleFactors

            ///<summary>Bezel Properties</summary>
            [FieldOffset(40)] PIEBezelProperties BezelProperties;

            ///<summary>Android Properties</summary>
            [FieldOffset(72)] PIEAndroidDeviceProperties AndroidProperties;

            ///<summary>IOSProperties</summary>
            [FieldOffset(232)] PIEIOSDeviceProperties IOSProperties;

        }
}
