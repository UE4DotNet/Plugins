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


namespace UE4.Foliage.Native {
    [StructLayout( LayoutKind.Explicit, Size=304 )]
    internal unsafe struct ProceduralFoliageComponent_fields {
        [FieldOffset(256)]  public IntPtr  FoliageSpawner;
        [FieldOffset(264)] public float TileOverlap;
        [FieldOffset(268)] public bool bAllowLandscape;
        [FieldOffset(269)] public bool bAllowBSP;
        [FieldOffset(270)] public bool bAllowStaticMesh;
        [FieldOffset(271)] public bool bAllowTranslucent;
        [FieldOffset(272)] public bool bAllowFoliage;
        [FieldOffset(273)] public bool bShowDebugTiles;
        [FieldOffset(280)]  public IntPtr  SpawningVolume;
        [FieldOffset(288)] public FGuid ProceduralGuid;
    }
    internal unsafe struct ProceduralFoliageComponent_methods {
    }
    internal unsafe struct ProceduralFoliageComponent_events {
    }
}
