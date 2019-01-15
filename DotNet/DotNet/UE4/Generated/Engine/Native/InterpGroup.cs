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
    [StructLayout( LayoutKind.Explicit, Size=104 )]
    internal unsafe struct InterpGroup_fields {
        [FieldOffset(64)] public NativeArray InterpTracks;
        [FieldOffset(80)] public Name GroupName;
        [FieldOffset(92)] public Color GroupColor;
        [FieldOffset(96)] public bool bCollapsed;
        [FieldOffset(96)] public bool bVisible;
        [FieldOffset(96)] public bool bIsFolder;
        [FieldOffset(96)] public bool bIsParented;
        [FieldOffset(96)] public bool bIsSelected;
    }
    internal unsafe struct InterpGroup_methods {
    }
    internal unsafe struct InterpGroup_events {
    }
}
