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
    [StructLayout( LayoutKind.Explicit, Size=240 )]
    internal unsafe struct ParticleModuleKillBox_fields {
        [FieldOffset(72)] public RawDistributionVector LowerLeftCorner;
        [FieldOffset(152)] public RawDistributionVector UpperRightCorner;
        [FieldOffset(232)] public bool bAbsolute;
        [FieldOffset(232)] public bool bKillInside;
        [FieldOffset(232)] public bool bAxisAlignedAndFixedSize;
    }
    internal unsafe struct ParticleModuleKillBox_methods {
    }
    internal unsafe struct ParticleModuleKillBox_events {
    }
}
