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

using UE4.Engine;

namespace UE4.UnrealEd.Native {
    [StructLayout( LayoutKind.Explicit, Size=248 )]
    internal unsafe struct EditorSettings_fields {
        [FieldOffset(56)] public bool bLoadTheMostRecentlyLoadedProjectAtStartup;
        [FieldOffset(64)] public DirectoryPath LocalDerivedDataCache;
        [FieldOffset(80)] public DirectoryPath SharedDerivedDataCache;
        [FieldOffset(96)] public NativeArray RecentlyOpenedProjectFiles;
        [FieldOffset(112)] public NativeArray CreatedProjectPaths;
        [FieldOffset(128)] public bool bCopyStarterContentPreference;
        [FieldOffset(136)] public NativeArray CompletedSurveys;
        [FieldOffset(152)] public NativeArray InProgressSurveys;
        [FieldOffset(168)] public float AutoScalabilityWorkScaleAmount;
    }
    internal unsafe struct EditorSettings_methods {
    }
    internal unsafe struct EditorSettings_events {
    }
}
