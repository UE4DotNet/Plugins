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

namespace UE4.MovieSceneCapture {
    ///<summary>Used by UCompositionGraphCaptureSettings. Matches gamut oreder in TonemapCommon.usf OuputGamutMappingMatrix()</summary>
    public enum EHDRCaptureGamut {
        HCGM_Rec709 = 0x00000000, 
        HCGM_P3DCI = 0x00000001, 
        HCGM_Rec2020 = 0x00000002, 
        HCGM_ACES = 0x00000003, 
        HCGM_ACEScg = 0x00000004, 
        HCGM_Linear = 0x00000005, 
        HCGM_MAX = 0x00000006
    }
}
