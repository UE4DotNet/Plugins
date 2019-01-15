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
    ///<summary>Enumeration defines how to treat mono 2D playback. Mono sounds need to upmixed to stereo when played back in 2D.</summary>
    public enum EMonoChannelUpmixMethod {
        Linear = 0x00000000, 
        EqualPower = 0x00000001, 
        FullVolume = 0x00000002, 
        EMonoChannelUpmixMethod_MAX = 0x00000003
    }
}
