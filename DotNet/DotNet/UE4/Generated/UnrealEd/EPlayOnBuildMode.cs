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

namespace UE4.UnrealEd {
    ///<summary>Determines whether to build the executable when launching on device. Note the equivalence between these settings and EProjectPackagingBuild.</summary>
    public enum EPlayOnBuildMode {
        PlayOnBuild_Always = 0x00000000, 
        PlayOnBuild_Never = 0x00000001, 
        PlayOnBuild_Default = 0x00000002, 
        PlayOnBuild_IfEditorBuiltLocally = 0x00000003, 
        PlayOnBuild_MAX = 0x00000004
    }
}
