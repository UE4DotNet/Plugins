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
    [StructLayout( LayoutKind.Explicit, Size=168 )]
    internal unsafe struct AutomatedAssetImportData_fields {
        [FieldOffset(56)] byte GroupName; //TODO: string FString GroupName
        [FieldOffset(72)] public NativeArray Filenames;
        [FieldOffset(88)] byte DestinationPath; //TODO: string FString DestinationPath
        [FieldOffset(104)] byte FactoryName; //TODO: string FString FactoryName
        [FieldOffset(120)] public bool bReplaceExisting;
        [FieldOffset(121)] public bool bSkipReadOnly;
        [FieldOffset(128)]  public IntPtr  Factory;
        [FieldOffset(136)] byte LevelToLoad; //TODO: string FString LevelToLoad
    }
    internal unsafe struct AutomatedAssetImportData_methods {
    }
    internal unsafe struct AutomatedAssetImportData_events {
    }
}
