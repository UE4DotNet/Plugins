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

namespace UE4.ViewportInteraction {
    ///<summary>Methods of dragging objects around in VR</summary>
    public enum EViewportInteractionDraggingMode {
        Nothing = 0x00000000, 
        TransformablesWithGizmo = 0x00000001, 
        TransformablesAtLaserImpact = 0x00000002, 
        AssistingDrag = 0x00000003, 
        TransformablesFreely = 0x00000004, 
        World = 0x00000005, 
        Interactable = 0x00000006, 
        Material = 0x00000007, 
        EViewportInteractionDraggingMode_MAX = 0x00000008
    }
}
