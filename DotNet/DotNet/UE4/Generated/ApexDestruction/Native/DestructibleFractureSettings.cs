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


namespace UE4.ApexDestruction.Native {
    [StructLayout( LayoutKind.Explicit, Size=200 )]
    internal unsafe struct DestructibleFractureSettings_fields {
        [FieldOffset(56)] public int CellSiteCount;
        [FieldOffset(60)] public FractureMaterial FractureMaterialDesc;
        [FieldOffset(96)] public int RandomSeed;
        [FieldOffset(104)] byte VoronoiSites; //TODO: array TArray VoronoiSites
        [FieldOffset(120)] public int OriginalSubmeshCount;
        [FieldOffset(128)] byte Materials; //TODO: array TArray Materials
        [FieldOffset(144)] byte ChunkParameters; //TODO: array TArray ChunkParameters
    }
    internal unsafe struct DestructibleFractureSettings_methods {
    }
    internal unsafe struct DestructibleFractureSettings_events {
    }
}
