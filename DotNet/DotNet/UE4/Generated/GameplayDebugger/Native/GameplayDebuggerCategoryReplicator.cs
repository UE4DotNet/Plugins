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


namespace UE4.GameplayDebugger.Native {
    [StructLayout( LayoutKind.Explicit, Size=1120 )]
    internal unsafe struct GameplayDebuggerCategoryReplicator_fields {
        [FieldOffset(1008)]  public IntPtr  OwnerPC;
        [FieldOffset(1016)] public bool bIsEnabled;
        [FieldOffset(1024)] public GameplayDebuggerNetPack ReplicatedData;
        [FieldOffset(1048)] public GameplayDebuggerDebugActor DebugActor;
        [FieldOffset(1072)]  public IntPtr  RenderingComp;
    }
    internal unsafe struct GameplayDebuggerCategoryReplicator_methods {
    }
    internal unsafe struct GameplayDebuggerCategoryReplicator_events {
    }
}
