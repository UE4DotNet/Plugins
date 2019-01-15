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
    ///<summary>Enumerates types of color values that can be held by Slate color.</summary>
    ///<remarks>Should we use the specified color? If not, then which color from the style should we use.</remarks>
    public enum ESlateColorStylingMode {
        UseColor_Specified = 0x00000000, 
        UseColor_Specified_Link = 0x00000001, 
        UseColor_Foreground = 0x00000002, 
        UseColor_Foreground_Subdued = 0x00000003, 
        UseColor_MAX = 0x00000004
    }
}
