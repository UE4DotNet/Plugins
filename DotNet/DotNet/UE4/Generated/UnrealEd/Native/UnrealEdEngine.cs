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
    [StructLayout( LayoutKind.Explicit, Size=6464 )]
    internal unsafe struct UnrealEdEngine_fields {
        [FieldOffset(5808)]  public IntPtr  EditorOptionsInst;
        [FieldOffset(5816)]  public IntPtr  AutoReimportManager;
        [FieldOffset(5824)]  public IntPtr  MaterialCopyPasteBuffer;
        [FieldOffset(5832)] public NativeArray MatineeCopyPasteBuffer;
        [FieldOffset(5848)]  public IntPtr  SoundCueCopyPasteBuffer;
        [FieldOffset(5856)] public NativeArray AnimationCompressionAlgorithms;
        [FieldOffset(5872)] public NativeArray PackagesToBeFullyLoadedAtStartup;
        [FieldOffset(5888)]  public IntPtr  CurrentLODParentActor;
        [FieldOffset(5896)] public bool bNeedWarningForPkgEngineVer;
        [FieldOffset(5896)] public bool bNeedWarningForWritePermission;
        [FieldOffset(5920)] public NativeArray TemplateMapInfos;
        [FieldOffset(5936)]  public IntPtr  CookServer;
    }
    internal unsafe struct UnrealEdEngine_methods {
    }
    internal unsafe struct UnrealEdEngine_events {
    }
}
