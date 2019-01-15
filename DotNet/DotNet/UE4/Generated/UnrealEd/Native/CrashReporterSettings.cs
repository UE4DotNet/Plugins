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
    [StructLayout( LayoutKind.Explicit, Size=104 )]
    internal unsafe struct CrashReporterSettings_fields {
        [FieldOffset(56)] byte UploadSymbolsPath; //TODO: string FString UploadSymbolsPath
        [FieldOffset(72)] byte DownstreamStorage; //TODO: string FString DownstreamStorage
        [FieldOffset(88)] public NativeArray RemoteStorage;
    }
    internal unsafe struct CrashReporterSettings_methods {
    }
    internal unsafe struct CrashReporterSettings_events {
    }
}
