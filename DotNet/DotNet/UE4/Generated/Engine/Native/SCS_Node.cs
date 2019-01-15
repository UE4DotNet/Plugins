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
    [StructLayout( LayoutKind.Explicit, Size=352 )]
    internal unsafe struct SCS_Node_fields {
        [FieldOffset(56)] public IntPtr ComponentClass;
        [FieldOffset(64)]  public IntPtr  ComponentTemplate;
        [FieldOffset(72)] public BlueprintCookedComponentInstancingData CookedComponentInstancingData;
        [FieldOffset(160)] public Name VariableName;
        [FieldOffset(176)] byte CategoryName; //TODO: text FText CategoryName
        [FieldOffset(200)] public Name AttachToName;
        [FieldOffset(212)] public Name ParentComponentOrVariableName;
        [FieldOffset(224)] public Name ParentComponentOwnerClassName;
        [FieldOffset(236)] public bool bIsParentComponentNative;
        [FieldOffset(240)] public NativeArray ChildNodes;
        [FieldOffset(256)] public NativeArray MetaDataArray;
        [FieldOffset(272)] public FGuid VariableGuid;
        [FieldOffset(320)] public Name InternalVariableName;
    }
    internal unsafe struct SCS_Node_methods {
    }
    internal unsafe struct SCS_Node_events {
    }
}
