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
    ///<summary>Submix channel format.</summary>
    ///<remarks>
    ///Allows submixes to have sources mix to a particular channel configuration for potential effect chain requirements.
    ///Master submix will always render at the device channel count. All child submixes will be down-mixed (or up-mixed) to
    ///the device channel count. This feature exists to allow specific submix effects to do their work on multi-channel mixes
    ///of audio.
    ///</remarks>
    public enum ESubmixChannelFormat {
        Device = 0x00000000, 
        Stereo = 0x00000001, 
        Quad = 0x00000002, 
        FiveDotOne = 0x00000003, 
        SevenDotOne = 0x00000004, 
        Ambisonics = 0x00000005, 
        Count = 0x00000006, 
        ESubmixChannelFormat_MAX = 0x00000007
    }
}
