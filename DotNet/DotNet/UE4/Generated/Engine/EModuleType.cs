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
    ///ModuleType
    ///   Indicates the kind of emitter the module can be applied to.
    ///</summary>
    ///<remarks>
    ///ie, EPMT_Beam - only applies to beam emitters.
    ///
    ///   The TypeData field is present to speed up finding the TypeData module.
    ///</remarks>
    public enum EModuleType {
        EPMT_General = 0x00000000, 
        EPMT_TypeData = 0x00000001, 
        EPMT_Beam = 0x00000002, 
        EPMT_Trail = 0x00000003, 
        EPMT_Spawn = 0x00000004, 
        EPMT_Required = 0x00000005, 
        EPMT_Event = 0x00000006, 
        EPMT_Light = 0x00000007, 
        EPMT_SubUV = 0x00000008, 
        EPMT_MAX = 0x00000009
    }
}
