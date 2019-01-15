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

namespace UE4.Engine {
    ///<summary>A priority for sorting scene elements by depth.</summary>
    ///<remarks>Elements with higher priority occlude elements with lower priority, disregarding distance.</remarks>
    public enum ESceneDepthPriorityGroup {
        SDPG_World = 0x00000000, 
        SDPG_Foreground = 0x00000001, 
        SDPG_MAX = 0x00000002
    }
}
