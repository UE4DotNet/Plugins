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


namespace UE4.Paper2D.Native {
    [StructLayout( LayoutKind.Explicit, Size=168 )]
    internal unsafe struct PaperTileLayer_fields {
        [FieldOffset(56)] byte LayerName; //TODO: text FText LayerName
        [FieldOffset(80)] public int LayerWidth;
        [FieldOffset(84)] public int LayerHeight;
        [FieldOffset(88)] public bool bHiddenInEditor;
        [FieldOffset(88)] public bool bHiddenInGame;
        [FieldOffset(88)] public bool bLayerCollides;
        [FieldOffset(88)] public bool bOverrideCollisionThickness;
        [FieldOffset(88)] public bool bOverrideCollisionOffset;
        [FieldOffset(92)] public float CollisionThicknessOverride;
        [FieldOffset(96)] public float CollisionOffsetOverride;
        [FieldOffset(100)] public LinearColor LayerColor;
        [FieldOffset(116)] public int AllocatedWidth;
        [FieldOffset(120)] public int AllocatedHeight;
        [FieldOffset(128)] public NativeArray AllocatedCells;
    }
    internal unsafe struct PaperTileLayer_methods {
    }
    internal unsafe struct PaperTileLayer_events {
    }
}
