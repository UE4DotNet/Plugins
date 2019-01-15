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
    ///<summary>This is the type of response the graph editor should take when making a connection</summary>
    public enum ECanCreateConnectionResponse {
        CONNECT_RESPONSE_MAKE = 0x00000000, 
        CONNECT_RESPONSE_DISALLOW = 0x00000001, 
        CONNECT_RESPONSE_BREAK_OTHERS_A = 0x00000002, 
        CONNECT_RESPONSE_BREAK_OTHERS_B = 0x00000003, 
        CONNECT_RESPONSE_BREAK_OTHERS_AB = 0x00000004, 
        CONNECT_RESPONSE_MAKE_WITH_CONVERSION_NODE = 0x00000005, 
        CONNECT_RESPONSE_MAX = 0x00000006
    }
}
