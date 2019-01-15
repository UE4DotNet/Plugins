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
    [StructLayout( LayoutKind.Explicit, Size=136 )]
    internal unsafe struct AssetExportTask_fields {
        [FieldOffset(56)]  public IntPtr  UObject;
        [FieldOffset(64)]  public IntPtr  Exporter;
        [FieldOffset(72)] byte Filename; //TODO: string FString Filename
        [FieldOffset(88)] public bool bSelected;
        [FieldOffset(89)] public bool bReplaceIdentical;
        [FieldOffset(90)] public bool bPrompt;
        [FieldOffset(91)] public bool bAutomated;
        [FieldOffset(92)] public bool bUseFileArchive;
        [FieldOffset(93)] public bool bWriteEmptyFiles;
        [FieldOffset(96)] public NativeArray IgnoreObjectList;
        [FieldOffset(112)]  public IntPtr  Options;
        [FieldOffset(120)] public NativeArray Errors;
    }
    internal unsafe struct AssetExportTask_methods {
    }
    internal unsafe struct AssetExportTask_events {
    }
}
