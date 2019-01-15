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
    [StructLayout( LayoutKind.Explicit, Size=192 )]
    internal unsafe struct PlatformInterfaceWebResponse_fields {
        [FieldOffset(56)] byte OriginalURL; //TODO: string FString OriginalURL
        [FieldOffset(72)] public int ResponseCode;
        [FieldOffset(76)] public int Tag;
        [FieldOffset(80)] byte StringResponse; //TODO: string FString StringResponse
        [FieldOffset(96)] public NativeArray BinaryResponse;
    }
    internal unsafe struct PlatformInterfaceWebResponse_methods {
    }
    internal unsafe struct PlatformInterfaceWebResponse_events {
    }
}
