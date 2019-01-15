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


namespace UE4.UnrealEd.Native {
    [StructLayout( LayoutKind.Explicit, Size=104 )]
    internal unsafe struct LevelEditor2DSettings_fields {
        [FieldOffset(80)] public bool bEnable2DWidget;
        [FieldOffset(81)] public bool bEnableSnapLayers;
        [FieldOffset(82)] byte SnapAxis; //TODO: enum ELevelEditor2DAxis SnapAxis
        [FieldOffset(88)] public NativeArray SnapLayers;
    }
    internal unsafe struct LevelEditor2DSettings_methods {
    }
    internal unsafe struct LevelEditor2DSettings_events {
    }
}
