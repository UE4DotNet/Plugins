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


namespace UE4.UMGEditor.Native {
    [StructLayout( LayoutKind.Explicit, Size=192 )]
    internal unsafe struct UMGEditorProjectSettings_fields {
        [FieldOffset(80)] public WidgetCompilerOptions DefaultCompilerOptions;
        [FieldOffset(104)] public NativeArray DirectoryCompilerOptions;
        [FieldOffset(120)] public bool bShowWidgetsFromEngineContent;
        [FieldOffset(121)] public bool bShowWidgetsFromDeveloperContent;
        [FieldOffset(128)] public NativeArray CategoriesToHide;
        [FieldOffset(144)] public NativeArray WidgetClassesToHide;
        [FieldOffset(160)] public NativeArray DebugResolutions;
        [FieldOffset(176)] public int Version;
    }
    internal unsafe struct UMGEditorProjectSettings_methods {
    }
    internal unsafe struct UMGEditorProjectSettings_events {
    }
}
