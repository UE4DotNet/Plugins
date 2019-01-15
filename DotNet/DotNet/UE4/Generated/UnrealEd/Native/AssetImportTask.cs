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
    [StructLayout( LayoutKind.Explicit, Size=136 )]
    internal unsafe struct AssetImportTask_fields {
        [FieldOffset(56)] byte Filename; //TODO: string FString Filename
        [FieldOffset(72)] byte DestinationPath; //TODO: string FString DestinationPath
        [FieldOffset(88)] byte DestinationName; //TODO: string FString DestinationName
        [FieldOffset(104)] public bool bReplaceExisting;
        [FieldOffset(105)] public bool bAutomated;
        [FieldOffset(106)] public bool bSave;
        [FieldOffset(112)]  public IntPtr  Options;
        [FieldOffset(120)] public NativeArray ImportedObjectPaths;
    }
    internal unsafe struct AssetImportTask_methods {
    }
    internal unsafe struct AssetImportTask_events {
    }
}
