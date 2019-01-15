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
    ///<summary>
    ///Setting that controls behavior when movement is restricted to a 2D plane defined by a specific axis/normal,
    ///so that movement along the locked axis is not be possible.
    ///</summary>
    public enum EPlaneConstraintAxisSetting {
        Custom = 0x00000000, 
        X = 0x00000001, 
        Y = 0x00000002, 
        Z = 0x00000003, 
        UseGlobalPhysicsSetting = 0x00000004, 
        EPlaneConstraintAxisSetting_MAX = 0x00000005
    }
}
