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
    ///<summary>Enumerates states a blueprint can be in.</summary>
    public enum EBlueprintStatus {
        BS_Unknown = 0x00000000, 
        BS_Dirty = 0x00000001, 
        BS_Error = 0x00000002, 
        BS_UpToDate = 0x00000003, 
        BS_BeingCreated = 0x00000004, 
        BS_UpToDateWithWarnings = 0x00000005, 
        BS_MAX = 0x00000006
    }
}
