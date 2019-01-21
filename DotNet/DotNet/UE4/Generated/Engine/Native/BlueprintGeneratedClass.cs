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
    internal unsafe struct BlueprintGeneratedClass_fields {
        [FieldOffset(568)] public int NumReplicatedProperties;
        [FieldOffset(572)] public bool bHasNativizedParent;
        [FieldOffset(576)] public NativeArray DynamicBindingObjects;
        [FieldOffset(592)] public NativeArray ComponentTemplates;
        [FieldOffset(608)] public NativeArray Timelines;
        [FieldOffset(624)]  public IntPtr  SimpleConstructionScript;
        [FieldOffset(632)]  public IntPtr  InheritableComponentHandler;
        [FieldOffset(640)]  public IntPtr  UberGraphFunction;
        [FieldOffset(672)]  public IntPtr  OverridenArchetypeForCDO;
        [FieldOffset(680)] byte PropertyGuids; //TODO: map TMap PropertyGuids
        [FieldOffset(760)] byte CookedComponentInstancingData; //TODO: map TMap CookedComponentInstancingData
    }
    internal unsafe struct BlueprintGeneratedClass_methods {
    }
    internal unsafe struct BlueprintGeneratedClass_events {
    }
}
