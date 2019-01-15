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
    [StructLayout( LayoutKind.Explicit, Size=392 )]
    internal unsafe struct K2Node_Select_fields {
        [FieldOffset(224)] public int NumOptionPins;
        [FieldOffset(232)] public EdGraphPinType IndexPinType;
        [FieldOffset(344)]  public IntPtr  UEnum;
        [FieldOffset(352)] public NativeArray EnumEntries;
        [FieldOffset(368)] public NativeArray EnumEntryFriendlyNames;
        [FieldOffset(384)] public bool bReconstructNode;
    }
    internal unsafe struct K2Node_Select_methods {
    }
    internal unsafe struct K2Node_Select_events {
    }
}
