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
    [StructLayout( LayoutKind.Explicit, Size=128 )]
    internal unsafe struct Factory_fields {
        [FieldOffset(56)] public bool bCreateNew;
        [FieldOffset(64)] public IntPtr SupportedClass;
        [FieldOffset(72)] public IntPtr ContextClass;
        [FieldOffset(80)] public NativeArray Formats;
        [FieldOffset(96)] public bool bEditAfterNew;
        [FieldOffset(96)] public bool bEditorImport;
        [FieldOffset(96)] public bool bText;
        [FieldOffset(100)] public int ImportPriority;
        [FieldOffset(104)]  public IntPtr  AutomatedImportData;
        [FieldOffset(112)]  public IntPtr  AssetImportTask;
        [FieldOffset(120)] public int OverwriteYesOrNoToAllState;
    }
    internal unsafe struct Factory_methods {
    }
    internal unsafe struct Factory_events {
    }
}
