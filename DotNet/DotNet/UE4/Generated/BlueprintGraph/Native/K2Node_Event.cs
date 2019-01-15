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

namespace UE4.BlueprintGraph.Native {
    [StructLayout( LayoutKind.Explicit, Size=368 )]
    internal unsafe struct K2Node_Event_fields {
        [FieldOffset(256)] public MemberReference EventReference;
        [FieldOffset(312)] public bool bOverrideFunction;
        [FieldOffset(312)] public bool bInternalEvent;
        [FieldOffset(316)] public Name CustomFunctionName;
        [FieldOffset(328)] byte FunctionFlags; //TODO: numeric uint32 FunctionFlags
    }
    internal unsafe struct K2Node_Event_methods {
    }
    internal unsafe struct K2Node_Event_events {
    }
}
