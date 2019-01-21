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
        ///<summary>PIEAndroid Device Properties</summary>
        [StructLayout( LayoutKind.Explicit, Size=160 )]
        public unsafe struct PIEAndroidDeviceProperties {
            [FieldOffset(0)] byte GPUFamily; //TODO: string FString GPUFamily

            [FieldOffset(16)] byte GLVersion; //TODO: string FString GLVersion

            [FieldOffset(32)] byte VulkanVersion; //TODO: string FString VulkanVersion

            [FieldOffset(48)] byte AndroidVersion; //TODO: string FString AndroidVersion

            [FieldOffset(64)] byte DeviceMake; //TODO: string FString DeviceMake

            [FieldOffset(80)] byte DeviceModel; //TODO: string FString DeviceModel

            [FieldOffset(96)] byte DeviceBuildNumber; //TODO: string FString DeviceBuildNumber

            [FieldOffset(112)] public bool VulkanAvailable;

            [FieldOffset(113)] public bool UsingHoudini;

            ///<summary>GLES2RHIState</summary>
            [FieldOffset(116)] PIERHIOverrideState GLES2RHIState;

            ///<summary>GLES31RHIState</summary>
            [FieldOffset(136)] PIERHIOverrideState GLES31RHIState;

        }
}
