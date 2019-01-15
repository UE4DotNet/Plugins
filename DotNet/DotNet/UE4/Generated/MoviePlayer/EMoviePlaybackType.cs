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

namespace UE4.MoviePlayer {
    ///<summary>In order for a platform to support early movie playback, the platform must support the rendering thread</summary>
    ///<remarks>starting very early and support rendering as soon as it is started and the module containing the movie streamer for the platform must already be loaded</remarks>
    public enum EMoviePlaybackType {
        MT_Normal = 0x00000000, 
        MT_Looped = 0x00000001, 
        MT_LoadingLoop = 0x00000002, 
        MT_MAX = 0x00000003
    }
}
