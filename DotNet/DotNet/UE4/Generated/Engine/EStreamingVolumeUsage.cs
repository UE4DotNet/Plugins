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
    ///<summary>Enum for different usage cases of level streaming volumes.</summary>
    public enum EStreamingVolumeUsage {
        SVB_Loading = 0x00000000, 
        SVB_LoadingAndVisibility = 0x00000001, 
        SVB_VisibilityBlockingOnLoad = 0x00000002, 
        SVB_BlockingOnLoad = 0x00000003, 
        SVB_LoadingNotVisible = 0x00000004, 
        SVB_MAX = 0x00000005
    }
}
