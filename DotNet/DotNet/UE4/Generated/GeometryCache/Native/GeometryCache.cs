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


namespace UE4.GeometryCache.Native {
    [StructLayout( LayoutKind.Explicit, Size=128 )]
    internal unsafe struct GeometryCache_fields {
        [FieldOffset(64)]  public IntPtr  AssetImportData;
        [FieldOffset(72)]  public IntPtr  ThumbnailInfo;
        [FieldOffset(80)] public NativeArray Materials;
        [FieldOffset(96)] public NativeArray Tracks;
        [FieldOffset(120)] public int StartFrame;
        [FieldOffset(124)] public int EndFrame;
    }
    internal unsafe struct GeometryCache_methods {
    }
    internal unsafe struct GeometryCache_events {
    }
}
