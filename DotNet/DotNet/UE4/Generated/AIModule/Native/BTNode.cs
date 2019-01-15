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
    [StructLayout( LayoutKind.Explicit, Size=112 )]
    internal unsafe struct BTNode_fields {
        [FieldOffset(64)] byte NodeName; //TODO: string FString NodeName
        [FieldOffset(80)]  public IntPtr  TreeAsset;
        [FieldOffset(88)]  public IntPtr  ParentNode;
    }
    internal unsafe struct BTNode_methods {
    }
    internal unsafe struct BTNode_events {
    }
}
