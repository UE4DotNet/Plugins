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

namespace UE4.MagicLeap {
    ///<summary>Control flags for plane queries.</summary>
    public enum EPlaneQueryFlags {
        Vertical = 0x00000000, 
        Horizontal = 0x00000001, 
        Arbitrary = 0x00000002, 
        OrientToGravity = 0x00000003, 
        PreferInner = 0x00000004, 
        IgnoreHoles = 0x00000005, 
        Ceiling = 0x00000006, 
        Floor = 0x00000007, 
        Wall = 0x00000008, 
        EPlaneQueryFlags_MAX = 0x00000009
    }
}
