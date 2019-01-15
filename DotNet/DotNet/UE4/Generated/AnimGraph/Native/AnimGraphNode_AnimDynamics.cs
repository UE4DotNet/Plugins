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

using UE4.AnimGraphRuntime;

namespace UE4.AnimGraph.Native {
    [StructLayout( LayoutKind.Explicit, Size=1456 )]
    internal unsafe struct AnimGraphNode_AnimDynamics_fields {
        [FieldOffset(272)] public AnimNode_AnimDynamics Node;
        [FieldOffset(1264)] public bool bPreviewLive;
        [FieldOffset(1265)] public bool bShowLinearLimits;
        [FieldOffset(1266)] public bool bShowAngularLimits;
        [FieldOffset(1267)] public bool bShowPlanarLimit;
        [FieldOffset(1268)] public bool bShowSphericalLimit;
        [FieldOffset(1269)] public bool bShowCollisionSpheres;
        [FieldOffset(1272)]  public IntPtr  LastPreviewComponent;
    }
    internal unsafe struct AnimGraphNode_AnimDynamics_methods {
    }
    internal unsafe struct AnimGraphNode_AnimDynamics_events {
    }
}
