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
    [StructLayout( LayoutKind.Explicit, Size=384 )]
    internal unsafe struct ParticleModuleTypeDataBeam2_fields {
        [FieldOffset(72)] public byte BeamMethod;
        [FieldOffset(76)] public int TextureTile;
        [FieldOffset(80)] public float TextureTileDistance;
        [FieldOffset(84)] public int Sheets;
        [FieldOffset(88)] public int MaxBeamCount;
        [FieldOffset(92)] public float Speed;
        [FieldOffset(96)] public int InterpolationPoints;
        [FieldOffset(100)] public bool bAlwaysOn;
        [FieldOffset(104)] public int UpVectorStepSize;
        [FieldOffset(108)] public Name BranchParentName;
        [FieldOffset(120)] public RawDistributionFloat Distance;
        [FieldOffset(176)] public byte TaperMethod;
        [FieldOffset(184)] public RawDistributionFloat TaperFactor;
        [FieldOffset(240)] public RawDistributionFloat TaperScale;
        [FieldOffset(296)] public bool RenderGeometry;
        [FieldOffset(296)] public bool RenderDirectLine;
        [FieldOffset(296)] public bool RenderLines;
        [FieldOffset(296)] public bool RenderTessellation;
    }
    internal unsafe struct ParticleModuleTypeDataBeam2_methods {
    }
    internal unsafe struct ParticleModuleTypeDataBeam2_events {
    }
}
