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


namespace UE4.UdpMessaging.Native {
    [StructLayout( LayoutKind.Explicit, Size=176 )]
    internal unsafe struct UdpMessagingSettings_fields {
        [FieldOffset(56)] public bool EnableTransport;
        [FieldOffset(64)] byte UnicastEndpoint; //TODO: string FString UnicastEndpoint
        [FieldOffset(80)] byte MulticastEndpoint; //TODO: string FString MulticastEndpoint
        [FieldOffset(96)] public byte MulticastTimeToLive;
        [FieldOffset(104)] public NativeArray StaticEndpoints;
        [FieldOffset(120)] public bool EnableTunnel;
        [FieldOffset(128)] byte TunnelUnicastEndpoint; //TODO: string FString TunnelUnicastEndpoint
        [FieldOffset(144)] byte TunnelMulticastEndpoint; //TODO: string FString TunnelMulticastEndpoint
        [FieldOffset(160)] public NativeArray RemoteTunnelEndpoints;
    }
    internal unsafe struct UdpMessagingSettings_methods {
    }
    internal unsafe struct UdpMessagingSettings_events {
    }
}
