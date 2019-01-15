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

using UE4.Engine;

namespace UE4.AnimGraph.Native {
    [StructLayout( LayoutKind.Explicit, Size=784 )]
    internal unsafe struct AnimStateNode_fields {
        [FieldOffset(208)]  public IntPtr  BoundGraph;
        [FieldOffset(216)] public byte StateType;
        [FieldOffset(224)] public AnimNotifyEvent StateEntered;
        [FieldOffset(408)] public AnimNotifyEvent StateLeft;
        [FieldOffset(592)] public AnimNotifyEvent StateFullyBlended;
        [FieldOffset(776)] public bool bAlwaysResetOnEntry;
    }
    internal unsafe struct AnimStateNode_methods {
    }
    internal unsafe struct AnimStateNode_events {
    }
}
