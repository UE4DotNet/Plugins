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
    [StructLayout( LayoutKind.Explicit, Size=184 )]
    internal unsafe struct EdGraph_fields {
        [FieldOffset(56)] public IntPtr Schema;
        [FieldOffset(64)] public NativeArray Nodes;
        [FieldOffset(80)] public bool bEditable;
        [FieldOffset(80)] public bool bAllowDeletion;
        [FieldOffset(80)] public bool bAllowRenaming;
        [FieldOffset(88)] public NativeArray SubGraphs;
        [FieldOffset(104)] public FGuid GraphGuid;
        [FieldOffset(120)] public FGuid InterfaceGuid;
    }
    internal unsafe struct EdGraph_methods {
    }
    internal unsafe struct EdGraph_events {
    }
}
