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
    [StructLayout( LayoutKind.Explicit, Size=144 )]
    internal unsafe struct BrushBuilder_fields {
        [FieldOffset(56)] byte BitmapFilename; //TODO: string FString BitmapFilename
        [FieldOffset(72)] byte ToolTip; //TODO: string FString ToolTip
        [FieldOffset(88)] public bool NotifyBadParams;
        [FieldOffset(96)] public NativeArray Vertices;
        [FieldOffset(112)] public NativeArray Polys;
        [FieldOffset(128)] public Name Layer;
        [FieldOffset(140)] public bool MergeCoplanars;
    }
    internal unsafe struct BrushBuilder_methods {
    }
    internal unsafe struct BrushBuilder_events {
    }
}
