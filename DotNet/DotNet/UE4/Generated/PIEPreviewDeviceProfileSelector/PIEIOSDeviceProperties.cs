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
        ///<summary>PIEIOSDevice Properties</summary>
        [StructLayout( LayoutKind.Explicit, Size=56 )]
        public unsafe struct PIEIOSDeviceProperties {
            [FieldOffset(0)] byte DeviceModel; //TODO: string FString DeviceModel

            ///<summary>GLES2RHIState</summary>
            [FieldOffset(16)] PIERHIOverrideState GLES2RHIState;

            ///<summary>Metal RHIState</summary>
            [FieldOffset(36)] PIERHIOverrideState MetalRHIState;

        }
}
