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


namespace UE4.Engine.Native {
    [StructLayout( LayoutKind.Explicit, Size=168 )]
    internal unsafe struct InterpData_fields {
        [FieldOffset(56)] public float InterpLength;
        [FieldOffset(60)] public float PathBuildTime;
        [FieldOffset(64)] public NativeArray InterpGroups;
        [FieldOffset(80)]  public IntPtr  CurveEdSetup;
        [FieldOffset(88)] public NativeArray InterpFilters;
        [FieldOffset(104)]  public IntPtr  SelectedFilter;
        [FieldOffset(112)] public NativeArray DefaultFilters;
        [FieldOffset(128)] public float EdSectionStart;
        [FieldOffset(132)] public float EdSectionEnd;
        [FieldOffset(136)] public bool bShouldBakeAndPrune;
        [FieldOffset(144)]  public IntPtr  CachedDirectorGroup;
        [FieldOffset(152)] public NativeArray AllEventNames;
    }
    internal unsafe struct InterpData_methods {
    }
    internal unsafe struct InterpData_events {
    }
}
