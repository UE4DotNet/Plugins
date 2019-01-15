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

namespace UE4.Landscape {
    ///<summary>this is only here because putting it in LandscapeEditorObject.</summary>
    ///<remarks>
    ///h (where it belongs)
    ///results in Engine being dependent on LandscapeEditor, as the actual landscape editing
    ///code (e.g. LandscapeEdit.h) is in /Engine/ for some reason...
    ///</remarks>
    public enum ELandscapeLayerPaintingRestriction {
        None = 0x00000000, 
        UseMaxLayers = 0x00000001, 
        ExistingOnly = 0x00000002, 
        UseComponentWhitelist = 0x00000003, 
        ELandscapeLayerPaintingRestriction_MAX = 0x00000004
    }
}
