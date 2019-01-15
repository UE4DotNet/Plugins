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

namespace UE4.OnlineSubsystem {
    ///<summary>Possible result states of an in-app purchase transaction</summary>
    public enum EInAppPurchaseState {
        Unknown = 0x00000000, 
        Success = 0x00000001, 
        Failed = 0x00000002, 
        Cancelled = 0x00000003, 
        Invalid = 0x00000004, 
        NotAllowed = 0x00000005, 
        Restored = 0x00000006, 
        AlreadyOwned = 0x00000007, 
        EInAppPurchaseState_MAX = 0x00000008
    }
}
