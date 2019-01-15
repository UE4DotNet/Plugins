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
    [StructLayout( LayoutKind.Explicit, Size=200 )]
    internal unsafe struct ParticleLODLevel_fields {
        [FieldOffset(56)] public int Level;
        [FieldOffset(60)] public bool bEnabled;
        [FieldOffset(64)]  public IntPtr  RequiredModule;
        [FieldOffset(72)] public NativeArray Modules;
        [FieldOffset(88)]  public IntPtr  TypeDataModule;
        [FieldOffset(96)]  public IntPtr  SpawnModule;
        [FieldOffset(104)]  public IntPtr  EventGenerator;
        [FieldOffset(112)] public NativeArray SpawningModules;
        [FieldOffset(128)] public NativeArray SpawnModules;
        [FieldOffset(144)] public NativeArray UpdateModules;
        [FieldOffset(160)] public NativeArray OrbitModules;
        [FieldOffset(176)] public NativeArray EventReceiverModules;
        [FieldOffset(192)] public bool ConvertedModules;
        [FieldOffset(196)] public int PeakActiveParticles;
    }
    internal unsafe struct ParticleLODLevel_methods {
    }
    internal unsafe struct ParticleLODLevel_events {
    }
}
