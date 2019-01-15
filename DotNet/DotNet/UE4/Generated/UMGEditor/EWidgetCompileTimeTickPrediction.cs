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

namespace UE4.UMGEditor {
    ///<summary>
    ///This represents the tickability of a widget computed at compile time
    ///It is designed as a hint so the runtime can determine if ticking needs to be enabled
    ///</summary>
    ///<remarks>A lot of widgets set to WillTick means you might have a performance problem</remarks>
    public enum EWidgetCompileTimeTickPrediction {
        WontTick = 0x00000000, 
        OnDemand = 0x00000001, 
        WillTick = 0x00000002, 
        EWidgetCompileTimeTickPrediction_MAX = 0x00000003
    }
}
