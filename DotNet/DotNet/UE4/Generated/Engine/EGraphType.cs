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
    ///<summary>Distinguishes between different graph types. Graphs can have different properties; for example: functions have one entry point, ubergraphs can have multiples.</summary>
    public enum EGraphType {
        GT_Function = 0x00000000, 
        GT_Ubergraph = 0x00000001, 
        GT_Macro = 0x00000002, 
        GT_Animation = 0x00000003, 
        GT_StateMachine = 0x00000004, 
        GT_MAX = 0x00000005
    }
}
