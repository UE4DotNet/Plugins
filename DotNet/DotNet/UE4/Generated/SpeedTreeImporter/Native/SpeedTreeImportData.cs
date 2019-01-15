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


namespace UE4.SpeedTreeImporter.Native {
    [StructLayout( LayoutKind.Explicit, Size=120 )]
    internal unsafe struct SpeedTreeImportData_fields {
        [FieldOffset(104)] public float TreeScale;
        [FieldOffset(108)] public byte ImportGeometryType;
        [FieldOffset(109)] public byte LODType;
        [FieldOffset(112)] public bool IncludeCollision;
        [FieldOffset(112)] public bool MakeMaterialsCheck;
        [FieldOffset(112)] public bool IncludeNormalMapCheck;
        [FieldOffset(112)] public bool IncludeDetailMapCheck;
        [FieldOffset(112)] public bool IncludeSpecularMapCheck;
        [FieldOffset(112)] public bool IncludeBranchSeamSmoothing;
        [FieldOffset(112)] public bool IncludeSpeedTreeAO;
        [FieldOffset(112)] public bool IncludeColorAdjustment;
        [FieldOffset(113)] public bool IncludeSubsurface;
        [FieldOffset(113)] public bool IncludeVertexProcessingCheck;
        [FieldOffset(113)] public bool IncludeWindCheck;
        [FieldOffset(113)] public bool IncludeSmoothLODCheck;
    }
    internal unsafe struct SpeedTreeImportData_methods {
    }
    internal unsafe struct SpeedTreeImportData_events {
    }
}
