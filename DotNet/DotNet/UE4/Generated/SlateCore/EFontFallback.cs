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

namespace UE4.SlateCore {
    ///<summary>Sets the maximum font fallback level, for when a character can't be found in the selected font set.</summary>
    ///<remarks>
    ///UI code that renders strings from a third party (e.g. player chat in a multiplayer game), should restrict font fallback to localized,
    ///(or to no fallback, if international font isn't important), to prevent potential performance problems.
    ///</remarks>
    public enum EFontFallback {
        FF_NoFallback = 0x00000000, 
        FF_LocalizedFallback = 0x00000001, 
        FF_LastResortFallback = 0x00000002, 
        FF_Max = 0x00000003, 
        FF_MAX = 0x00000004
    }
}
