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

namespace UE4.HeadMountedDisplay {
    ///<summary>Stores if the user is wearing the HMD or not. For HMDs without a sensor to detect the user wearing it, the state defaults to Unknown.</summary>
    public enum EHMDWornState {
        Unknown = 0x00000000, 
        Worn = 0x00000001, 
        NotWorn = 0x00000002, 
        EHMDWornState_MAX = 0x00000003
    }
}
