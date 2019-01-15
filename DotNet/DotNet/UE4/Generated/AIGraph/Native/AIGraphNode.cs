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


namespace UE4.AIGraph.Native {
    [StructLayout( LayoutKind.Explicit, Size=368 )]
    internal unsafe struct AIGraphNode_fields {
        [FieldOffset(208)] public GraphNodeClassData ClassData;
        [FieldOffset(312)]  public IntPtr  NodeInstance;
        [FieldOffset(320)]  public IntPtr  ParentNode;
        [FieldOffset(328)] public NativeArray SubNodes;
        [FieldOffset(344)] public int CopySubNodeIndex;
        [FieldOffset(348)] public bool bIsReadOnly;
        [FieldOffset(348)] public bool bIsSubNode;
        [FieldOffset(352)] byte ErrorMessage; //TODO: string FString ErrorMessage
    }
    internal unsafe struct AIGraphNode_methods {
    }
    internal unsafe struct AIGraphNode_events {
    }
}
