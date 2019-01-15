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

namespace UE4.LocationServicesBPLibrary {
    ///<summary>Enum used to determine what accuracy the Location Services should be run with.</summary>
    ///<remarks>
    ///Based off the iOS kCLLocationAccuracy
    ///enums since those were the most restrictive (but convienently also had descriptive names)
    ///</remarks>
    public enum ELocationAccuracy {
        LA_ThreeKilometers = 0x00000000, 
        LA_OneKilometer = 0x00000001, 
        LA_HundredMeters = 0x00000002, 
        LA_TenMeters = 0x00000003, 
        LA_Best = 0x00000004, 
        LA_Navigation = 0x00000005, 
        LA_MAX = 0x00000006
    }
}
