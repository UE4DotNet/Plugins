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
    ///<summary>ENav Path Event</summary>
    public enum ENavPathEvent {
        Cleared = 0x00000000, 
        NewPath = 0x00000001, 
        UpdatedDueToGoalMoved = 0x00000002, 
        UpdatedDueToNavigationChanged = 0x00000003, 
        Invalidated = 0x00000004, 
        RePathFailed = 0x00000005, 
        MetaPathUpdate = 0x00000006, 
        Custom = 0x00000007, 
        ENavPathEvent_MAX = 0x00000008
    }
}
