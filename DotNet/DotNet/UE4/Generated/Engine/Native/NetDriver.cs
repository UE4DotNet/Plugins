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
    [StructLayout( LayoutKind.Explicit, Size=1392 )]
    internal unsafe struct NetDriver_fields {
        [FieldOffset(64)] byte NetConnectionClassName; //TODO: string FString NetConnectionClassName
        [FieldOffset(80)] byte ReplicationDriverClassName; //TODO: string FString ReplicationDriverClassName
        [FieldOffset(96)] public int MaxDownloadSize;
        [FieldOffset(100)] public bool bClampListenServerTickRate;
        [FieldOffset(104)] public int NetServerMaxTickRate;
        [FieldOffset(108)] public int MaxInternetClientRate;
        [FieldOffset(112)] public int MaxClientRate;
        [FieldOffset(116)] public float ServerTravelPause;
        [FieldOffset(120)] public float SpawnPrioritySeconds;
        [FieldOffset(124)] public float RelevantTimeout;
        [FieldOffset(128)] public float KeepAliveTime;
        [FieldOffset(132)] public float InitialConnectTimeout;
        [FieldOffset(136)] public float ConnectionTimeout;
        [FieldOffset(140)] public float TimeoutMultiplierForUnoptimizedBuilds;
        [FieldOffset(144)] public bool bNoTimeouts;
        [FieldOffset(152)]  public IntPtr  ServerConnection;
        [FieldOffset(160)] public NativeArray ClientConnections;
        [FieldOffset(216)]  public IntPtr  World;
        [FieldOffset(224)]  public IntPtr  WorldPackage;
        [FieldOffset(264)] public IntPtr NetConnectionClass;
        [FieldOffset(272)] public IntPtr ReplicationDriverClass;
        [FieldOffset(280)]  public IntPtr  RoleProperty;
        [FieldOffset(288)]  public IntPtr  RemoteRoleProperty;
        [FieldOffset(296)] public Name NetDriverName;
        [FieldOffset(384)] public float Time;
        [FieldOffset(1360)]  public IntPtr  ReplicationDriver;
    }
    internal unsafe struct NetDriver_methods {
    }
    internal unsafe struct NetDriver_events {
    }
}
