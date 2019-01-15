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
    ///Enum for controlling buckets for update rate optimizations if we need to stagger
    ///Multiple actor populations separately.
    ///</summary>
    public enum EUpdateRateShiftBucket {
        ShiftBucket0 = 0x00000000, 
        ShiftBucket1 = 0x00000001, 
        ShiftBucket2 = 0x00000002, 
        ShiftBucket3 = 0x00000003, 
        ShiftBucket4 = 0x00000004, 
        ShiftBucket5 = 0x00000005, 
        ShiftBucketMax = 0x00000006, 
        EUpdateRateShiftBucket_MAX = 0x00000007
    }
}
