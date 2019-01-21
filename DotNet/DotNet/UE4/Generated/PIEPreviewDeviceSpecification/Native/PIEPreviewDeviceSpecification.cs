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


namespace UE4.PIEPreviewDeviceSpecification.Native {
    [StructLayout( LayoutKind.Explicit, Size=184 )]
    internal unsafe struct PIEPreviewDeviceSpecification_fields {
        [FieldOffset(56)] byte PreviewDeviceType; //TODO: enum EPIEPreviewDeviceType PreviewDeviceType
        [FieldOffset(64)] byte GPUFamily; //TODO: string FString GPUFamily
        [FieldOffset(80)] byte GLVersion; //TODO: string FString GLVersion
        [FieldOffset(96)] byte VulkanVersion; //TODO: string FString VulkanVersion
        [FieldOffset(112)] byte AndroidVersion; //TODO: string FString AndroidVersion
        [FieldOffset(128)] byte DeviceMake; //TODO: string FString DeviceMake
        [FieldOffset(144)] byte DeviceModel; //TODO: string FString DeviceModel
        [FieldOffset(160)] byte DeviceBuildNumber; //TODO: string FString DeviceBuildNumber
        [FieldOffset(176)] public bool UsingHoudini;
    }
    internal unsafe struct PIEPreviewDeviceSpecification_methods {
    }
    internal unsafe struct PIEPreviewDeviceSpecification_events {
    }
}
