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
    [StructLayout( LayoutKind.Explicit, Size=120 )]
    internal unsafe struct BlueprintEditorProjectSettings_fields {
        [FieldOffset(80)] public bool bDisableCompilationManager;
        [FieldOffset(80)] public bool bForceAllDependenciesToRecompile;
        [FieldOffset(80)] public bool bValidateUnloadedSoftActorReferences;
        [FieldOffset(88)] public NativeArray DisabledCompilerMessagesExceptEditor;
        [FieldOffset(104)] public NativeArray DisabledCompilerMessages;
    }
    internal unsafe struct BlueprintEditorProjectSettings_methods {
    }
    internal unsafe struct BlueprintEditorProjectSettings_events {
    }
}
