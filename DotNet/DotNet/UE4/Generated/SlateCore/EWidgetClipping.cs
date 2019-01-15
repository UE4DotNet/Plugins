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
    ///<summary>This enum controls clipping of widgets in Slate.</summary>
    ///<remarks>
    ///By default all SWidgets do not need to clip their children.
    ///Most of the time, you don't need to clip, the only times it becomes important is when something might become hidden
    ///due to panning.  You should use this wisely, as Slate can not batch across clipping areas, so if widget A and widget B
    ///are set to EWidgetClipping::Yes, no drawing that happens inside their widget trees will ever be batch together, adding
    ///additional GPU overhead.
    ///</remarks>
    public enum EWidgetClipping {
        Inherit = 0x00000000, 
        ClipToBounds = 0x00000001, 
        ClipToBoundsWithoutIntersecting = 0x00000002, 
        ClipToBoundsAlways = 0x00000003, 
        OnDemand = 0x00000004, 
        EWidgetClipping_MAX = 0x00000005
    }
}
