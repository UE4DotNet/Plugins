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
    [StructLayout( LayoutKind.Explicit, Size=200 )]
    internal unsafe struct UnrealEdOptions_fields {
        [FieldOffset(56)] public NativeArray EditorCategories;
        [FieldOffset(72)] public NativeArray EditorCommands;
        [FieldOffset(88)]  public IntPtr  EditorKeyBindings;
        [FieldOffset(96)] public bool bExpandClassPickerClassList;
        [FieldOffset(104)] public NativeArray NewAssetDefaultClasses;
    }
    internal unsafe struct UnrealEdOptions_methods {
    }
    internal unsafe struct UnrealEdOptions_events {
    }
}
