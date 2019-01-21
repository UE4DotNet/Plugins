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
    [StructLayout( LayoutKind.Explicit, Size=336 )]
    internal unsafe struct SCS_Node_fields {
        [FieldOffset(56)] public IntPtr ComponentClass;
        [FieldOffset(64)]  public IntPtr  ComponentTemplate;
        [FieldOffset(72)] public BlueprintCookedComponentInstancingData CookedComponentInstancingData;
        [FieldOffset(160)] byte CategoryName; //TODO: text FText CategoryName
        [FieldOffset(184)] public Name AttachToName;
        [FieldOffset(196)] public Name ParentComponentOrVariableName;
        [FieldOffset(208)] public Name ParentComponentOwnerClassName;
        [FieldOffset(220)] public bool bIsParentComponentNative;
        [FieldOffset(224)] public NativeArray ChildNodes;
        [FieldOffset(240)] public NativeArray MetaDataArray;
        [FieldOffset(256)] public FGuid VariableGuid;
        [FieldOffset(304)] public Name InternalVariableName;
    }
    internal unsafe struct SCS_Node_methods {
    }
    internal unsafe struct SCS_Node_events {
    }
}
