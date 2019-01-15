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


namespace UE4.BehaviorTreeEditor.Native {
    [StructLayout( LayoutKind.Explicit, Size=496 )]
    internal unsafe struct BehaviorTreeGraphNode_CompositeDecorator_fields {
        [FieldOffset(432)]  public IntPtr  BoundGraph;
        [FieldOffset(440)] byte CompositeName; //TODO: string FString CompositeName
        [FieldOffset(456)] public bool bShowOperations;
        [FieldOffset(456)] public bool bCanAbortFlow;
        [FieldOffset(464)]  public IntPtr  ParentNodeInstance;
        [FieldOffset(480)] byte CachedDescription; //TODO: string FString CachedDescription
    }
    internal unsafe struct BehaviorTreeGraphNode_CompositeDecorator_methods {
    }
    internal unsafe struct BehaviorTreeGraphNode_CompositeDecorator_events {
    }
}
