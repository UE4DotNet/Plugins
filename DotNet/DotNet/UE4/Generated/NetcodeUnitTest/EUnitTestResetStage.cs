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
    ///<summary>
    ///The different stages that unit tests can be reset to - a global/non-locally-customizable list, for now
    ///NOTE: Stages MUST be sequential! (e.
    ///</summary>
    ///<remarks>
    ///g. ResetConnection implies ResetExecute, FullReset implies both ResetConnection and ResetExecute)
    ///NOTE: Apart from checking for 'None', all comparisons should be either <= or >=, to support potential enum additions
    ///</remarks>
    public enum EUnitTestResetStage {
        None = 0x00000000, 
        FullReset = 0x00000001, 
        ResetConnection = 0x00000002, 
        ResetExecute = 0x00000003, 
        EUnitTestResetStage_MAX = 0x00000004
    }
}
