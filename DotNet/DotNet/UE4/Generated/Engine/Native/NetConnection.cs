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
    [StructLayout( LayoutKind.Explicit, Size=6456 )]
    internal unsafe struct NetConnection_fields {
        [FieldOffset(88)] public NativeArray Children;
        [FieldOffset(104)]  public IntPtr  Driver;
        [FieldOffset(112)] public IntPtr PackageMapClass;
        [FieldOffset(120)]  public IntPtr  PackageMap;
        [FieldOffset(128)] public NativeArray OpenChannels;
        [FieldOffset(144)] public NativeArray SentTemporaries;
        [FieldOffset(160)]  public IntPtr  ViewTarget;
        [FieldOffset(168)]  public IntPtr  OwningActor;
        [FieldOffset(176)] public int MaxPacket;
        [FieldOffset(180)] public bool InternalAck;
        [FieldOffset(360)] public UniqueNetIdRepl PlayerId;
        [FieldOffset(504)] public double LastReceiveTime;
        [FieldOffset(6112)] public NativeArray ChannelsToTick;
    }
    internal unsafe struct NetConnection_methods {
    }
    internal unsafe struct NetConnection_events {
    }
}
