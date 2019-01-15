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
    [StructLayout( LayoutKind.Explicit, Size=1072 )]
    internal unsafe struct Brush_fields {
        [FieldOffset(1008)] public byte BrushType;
        [FieldOffset(1012)] public Color BrushColor;
        [FieldOffset(1016)] public int PolyFlags;
        [FieldOffset(1020)] public bool bColored;
        [FieldOffset(1020)] public bool bSolidWhenSelected;
        [FieldOffset(1020)] public bool bPlaceableFromClassBrowser;
        [FieldOffset(1020)] public bool bNotForClientOrServer;
        [FieldOffset(1024)]  public IntPtr  Brush_;
        [FieldOffset(1032)]  public IntPtr  BrushComponent;
        [FieldOffset(1040)]  public IntPtr  BrushBuilder;
        [FieldOffset(1048)] public bool bInManipulation;
        [FieldOffset(1056)] public NativeArray SavedSelections;
    }
    internal unsafe struct Brush_methods {
    }
    internal unsafe struct Brush_events {
    }
}
