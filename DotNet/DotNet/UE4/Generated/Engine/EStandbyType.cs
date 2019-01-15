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
    ///<summary>Describes which standby detection event occured so the game can take appropriate action.</summary>
    public enum EStandbyType {
        STDBY_Rx = 0x00000000, 
        STDBY_Tx = 0x00000001, 
        STDBY_BadPing = 0x00000002, 
        STDBY_MAX = 0x00000003
    }
}
