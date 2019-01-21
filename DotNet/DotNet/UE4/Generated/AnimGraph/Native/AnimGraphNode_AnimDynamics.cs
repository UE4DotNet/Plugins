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
    [StructLayout( LayoutKind.Explicit, Size=1472 )]
    internal unsafe struct AnimGraphNode_AnimDynamics_fields {
        [FieldOffset(272)] public AnimNode_AnimDynamics Node;
        [FieldOffset(1280)] public bool bPreviewLive;
        [FieldOffset(1281)] public bool bShowLinearLimits;
        [FieldOffset(1282)] public bool bShowAngularLimits;
        [FieldOffset(1283)] public bool bShowPlanarLimit;
        [FieldOffset(1284)] public bool bShowSphericalLimit;
        [FieldOffset(1285)] public bool bShowCollisionSpheres;
        [FieldOffset(1288)]  public IntPtr  LastPreviewComponent;
    }
    internal unsafe struct AnimGraphNode_AnimDynamics_methods {
    }
    internal unsafe struct AnimGraphNode_AnimDynamics_events {
    }
}
