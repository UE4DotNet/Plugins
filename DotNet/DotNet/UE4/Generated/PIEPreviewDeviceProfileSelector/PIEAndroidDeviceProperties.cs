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
        ///<summary>PIEAndroid Device Properties</summary>
        [StructLayout( LayoutKind.Explicit, Size=144 )]
        public unsafe struct PIEAndroidDeviceProperties {
            [FieldOffset(0)] byte GPUFamily; //TODO: string FString GPUFamily

            [FieldOffset(16)] byte GLVersion; //TODO: string FString GLVersion

            [FieldOffset(32)] byte VulkanVersion; //TODO: string FString VulkanVersion

            [FieldOffset(48)] byte AndroidVersion; //TODO: string FString AndroidVersion

            [FieldOffset(64)] byte DeviceMake; //TODO: string FString DeviceMake

            [FieldOffset(80)] byte DeviceModel; //TODO: string FString DeviceModel

            [FieldOffset(96)] public bool VulkanAvailable;

            [FieldOffset(97)] public bool UsingHoudini;

            ///<summary>GLES2RHIState</summary>
            [FieldOffset(100)] PIERHIOverrideState GLES2RHIState;

            ///<summary>GLES31RHIState</summary>
            [FieldOffset(120)] PIERHIOverrideState GLES31RHIState;

        }
}
