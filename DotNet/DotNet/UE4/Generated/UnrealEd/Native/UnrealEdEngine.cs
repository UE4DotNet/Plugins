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
    [StructLayout( LayoutKind.Explicit, Size=6352 )]
    internal unsafe struct UnrealEdEngine_fields {
        [FieldOffset(5688)]  public IntPtr  EditorOptionsInst;
        [FieldOffset(5696)]  public IntPtr  AutoReimportManager;
        [FieldOffset(5704)]  public IntPtr  MaterialCopyPasteBuffer;
        [FieldOffset(5712)] public NativeArray MatineeCopyPasteBuffer;
        [FieldOffset(5728)]  public IntPtr  SoundCueCopyPasteBuffer;
        [FieldOffset(5736)] public NativeArray AnimationCompressionAlgorithms;
        [FieldOffset(5752)] public NativeArray PackagesToBeFullyLoadedAtStartup;
        [FieldOffset(5768)]  public IntPtr  CurrentLODParentActor;
        [FieldOffset(5776)] public bool bNeedWarningForPkgEngineVer;
        [FieldOffset(5776)] public bool bNeedWarningForWritePermission;
        [FieldOffset(5800)] public NativeArray TemplateMapInfos;
        [FieldOffset(5816)]  public IntPtr  CookServer;
    }
    internal unsafe struct UnrealEdEngine_methods {
    }
    internal unsafe struct UnrealEdEngine_events {
    }
}
