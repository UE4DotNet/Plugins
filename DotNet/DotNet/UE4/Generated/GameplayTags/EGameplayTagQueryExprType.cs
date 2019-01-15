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

namespace UE4.GameplayTags {
    ///<summary>Enumerates the list of supported query expression types.</summary>
    public enum EGameplayTagQueryExprType {
        Undefined = 0x00000000, 
        AnyTagsMatch = 0x00000001, 
        AllTagsMatch = 0x00000002, 
        NoTagsMatch = 0x00000003, 
        AnyExprMatch = 0x00000004, 
        AllExprMatch = 0x00000005, 
        NoExprMatch = 0x00000006, 
        EGameplayTagQueryExprType_MAX = 0x00000007
    }
}
