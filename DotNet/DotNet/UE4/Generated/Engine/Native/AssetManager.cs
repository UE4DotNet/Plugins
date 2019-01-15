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
    [StructLayout( LayoutKind.Explicit, Size=1160 )]
    internal unsafe struct AssetManager_fields {
        [FieldOffset(784)] public NativeArray ObjectReferenceList;
        [FieldOffset(800)] public bool bIsGlobalAsyncScanEnvironment;
        [FieldOffset(801)] public bool bShouldGuessTypeAndName;
        [FieldOffset(802)] public bool bShouldUseSynchronousLoad;
        [FieldOffset(803)] public bool bIsLoadingFromPakFiles;
        [FieldOffset(804)] public bool bShouldAcquireMissingChunksOnLoad;
        [FieldOffset(805)] public bool bOnlyCookProductionAssets;
        [FieldOffset(806)] public bool bIsBulkScanning;
        [FieldOffset(807)] public bool bIsManagementDatabaseCurrent;
        [FieldOffset(808)] public bool bUpdateManagementDatabaseAfterScan;
        [FieldOffset(809)] public bool bIncludeOnlyOnDiskAssets;
        [FieldOffset(812)] public int NumberOfSpawnedNotifications;
    }
    internal unsafe struct AssetManager_methods {
    }
    internal unsafe struct AssetManager_events {
    }
}
