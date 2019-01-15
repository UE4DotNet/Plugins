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


namespace UE4.AIModule.Native {
    [StructLayout( LayoutKind.Explicit, Size=136 )]
    internal unsafe struct BehaviorTree_fields {
        [FieldOffset(56)]  public IntPtr  RootNode;
        [FieldOffset(64)]  public IntPtr  BTGraph;
        [FieldOffset(72)] public NativeArray LastEditedDocuments;
        [FieldOffset(88)]  public IntPtr  BlackboardAsset;
        [FieldOffset(96)] public NativeArray RootDecorators;
        [FieldOffset(112)] public NativeArray RootDecoratorOps;
    }
    internal unsafe struct BehaviorTree_methods {
    }
    internal unsafe struct BehaviorTree_events {
    }
}
