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
    ///<summary>EMax Concurrent Resolution Rule</summary>
    public enum EMaxConcurrentResolutionRule {
        PreventNew = 0x00000000, 
        StopOldest = 0x00000001, 
        StopFarthestThenPreventNew = 0x00000002, 
        StopFarthestThenOldest = 0x00000003, 
        StopLowestPriority = 0x00000004, 
        StopQuietest = 0x00000005, 
        StopLowestPriorityThenPreventNew = 0x00000006, 
        EMaxConcurrentResolutionRule_MAX = 0x00000007
    }
}
