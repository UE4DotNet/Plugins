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
    [StructLayout( LayoutKind.Explicit, Size=248 )]
    internal unsafe struct DeviceProfile_fields {
        [FieldOffset(72)] byte DeviceType; //TODO: string FString DeviceType
        [FieldOffset(88)] byte BaseProfileName; //TODO: string FString BaseProfileName
        [FieldOffset(104)]  public IntPtr  Parent;
        [FieldOffset(136)] public NativeArray CVars;
    }
    internal unsafe struct DeviceProfile_methods {
    }
    internal unsafe struct DeviceProfile_events {
    }
}
