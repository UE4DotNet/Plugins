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

namespace UE4.NetcodeUnitTest {
    ///<summary>The verification status of the current unit test - normally its execution completes immediately after positive/negative verification</summary>
    public enum EUnitTestVerification {
        Unverified = 0x00000000, 
        VerifiedNotFixed = 0x00000001, 
        VerifiedFixed = 0x00000002, 
        VerifiedNeedsUpdate = 0x00000003, 
        VerifiedUnreliable = 0x00000004, 
        EUnitTestVerification_MAX = 0x00000005
    }
}
