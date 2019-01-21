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
        ///<summary>PIEBezel Properties</summary>
        [StructLayout( LayoutKind.Explicit, Size=32 )]
        public unsafe struct PIEBezelProperties {
            [FieldOffset(0)] byte DeviceBezelFile; //TODO: string FString DeviceBezelFile

            ///<summary>Bezel Viewport Rect</summary>
            [FieldOffset(16)] PIEPreviewDeviceBezelViewportRect BezelViewportRect;

        }
}
