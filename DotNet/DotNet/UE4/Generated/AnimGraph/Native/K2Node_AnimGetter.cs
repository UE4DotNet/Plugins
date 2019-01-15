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


namespace UE4.AnimGraph.Native {
    [StructLayout( LayoutKind.Explicit, Size=408 )]
    internal unsafe struct K2Node_AnimGetter_fields {
        [FieldOffset(336)]  public IntPtr  SourceNode;
        [FieldOffset(344)]  public IntPtr  SourceStateNode;
        [FieldOffset(352)] public IntPtr GetterClass;
        [FieldOffset(360)]  public IntPtr  SourceAnimBlueprint;
        [FieldOffset(368)] byte CachedTitle; //TODO: text FText CachedTitle
        [FieldOffset(392)] public NativeArray Contexts;
    }
    internal unsafe struct K2Node_AnimGetter_methods {
    }
    internal unsafe struct K2Node_AnimGetter_events {
    }
}
