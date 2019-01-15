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
    [StructLayout( LayoutKind.Explicit, Size=144 )]
    internal unsafe struct UMGEditorProjectSettings_fields {
        [FieldOffset(80)] public bool bCookSlowConstructionWidgetTree;
        [FieldOffset(81)] public bool bWidgetSupportsDynamicCreation;
        [FieldOffset(88)] public NativeArray DebugResolutions;
        [FieldOffset(104)] public bool bShowWidgetsFromEngineContent;
        [FieldOffset(105)] public bool bShowWidgetsFromDeveloperContent;
        [FieldOffset(112)] public NativeArray CategoriesToHide;
        [FieldOffset(128)] public NativeArray WidgetClassesToHide;
    }
    internal unsafe struct UMGEditorProjectSettings_methods {
    }
    internal unsafe struct UMGEditorProjectSettings_events {
    }
}
