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


namespace UE4.OnlineSubsystemUtils.Native {
    [StructLayout( LayoutKind.Explicit, Size=1440 )]
    internal unsafe struct IpNetDriver_fields {
        [FieldOffset(1392)] public bool LogPortUnreach;
        [FieldOffset(1392)] public bool AllowPlayerPortUnreach;
        [FieldOffset(1396)] byte MaxPortCountToTry; //TODO: numeric uint32 MaxPortCountToTry
        [FieldOffset(1424)] byte ServerDesiredSocketReceiveBufferBytes; //TODO: numeric uint32 ServerDesiredSocketReceiveBufferBytes
        [FieldOffset(1428)] byte ServerDesiredSocketSendBufferBytes; //TODO: numeric uint32 ServerDesiredSocketSendBufferBytes
        [FieldOffset(1432)] byte ClientDesiredSocketReceiveBufferBytes; //TODO: numeric uint32 ClientDesiredSocketReceiveBufferBytes
        [FieldOffset(1436)] byte ClientDesiredSocketSendBufferBytes; //TODO: numeric uint32 ClientDesiredSocketSendBufferBytes
    }
    internal unsafe struct IpNetDriver_methods {
    }
    internal unsafe struct IpNetDriver_events {
    }
}
