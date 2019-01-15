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

namespace UE4.HeadMountedDisplay {
    ///<summary>The Spectator Screen Mode controls what the non-vr video device displays on platforms that support one.</summary>
    ///<remarks>
    ///Not all modes are universal.
    ///Modes SingleEyeCroppedToFill, Texture, and MirrorPlusTexture are supported on all.
    ///Disabled is supported on all except PSVR.
    ///</remarks>
    public enum ESpectatorScreenMode {
        Disabled = 0x00000000, 
        SingleEyeLetterboxed = 0x00000001, 
        Undistorted = 0x00000002, 
        Distorted = 0x00000003, 
        SingleEye = 0x00000004, 
        SingleEyeCroppedToFill = 0x00000005, 
        Texture = 0x00000006, 
        TexturePlusEye = 0x00000007, 
        ESpectatorScreenMode_MAX = 0x00000008
    }
}
