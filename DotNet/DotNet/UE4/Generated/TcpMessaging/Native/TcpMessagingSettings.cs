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


namespace UE4.TcpMessaging.Native {
    [StructLayout( LayoutKind.Explicit, Size=104 )]
    internal unsafe struct TcpMessagingSettings_fields {
        [FieldOffset(56)] public bool EnableTransport;
        [FieldOffset(64)] byte ListenEndpoint; //TODO: string FString ListenEndpoint
        [FieldOffset(80)] public NativeArray ConnectToEndpoints;
        [FieldOffset(96)] public int ConnectionRetryDelay;
    }
    internal unsafe struct TcpMessagingSettings_methods {
    }
    internal unsafe struct TcpMessagingSettings_events {
    }
}
