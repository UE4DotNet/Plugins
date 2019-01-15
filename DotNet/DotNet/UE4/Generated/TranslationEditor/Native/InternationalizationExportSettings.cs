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


namespace UE4.TranslationEditor.Native {
    [StructLayout( LayoutKind.Explicit, Size=176 )]
    internal unsafe struct InternationalizationExportSettings_fields {
        [FieldOffset(56)] public NativeArray CulturesToGenerate;
        [FieldOffset(72)] byte CommandletClass; //TODO: string FString CommandletClass
        [FieldOffset(88)] byte SourcePath; //TODO: string FString SourcePath
        [FieldOffset(104)] byte DestinationPath; //TODO: string FString DestinationPath
        [FieldOffset(120)] byte PortableObjectName; //TODO: string FString PortableObjectName
        [FieldOffset(136)] byte ManifestName; //TODO: string FString ManifestName
        [FieldOffset(152)] byte ArchiveName; //TODO: string FString ArchiveName
        [FieldOffset(168)] public bool bExportLoc;
        [FieldOffset(169)] public bool bImportLoc;
        [FieldOffset(170)] public bool bUseCultureDirectory;
    }
    internal unsafe struct InternationalizationExportSettings_methods {
    }
    internal unsafe struct InternationalizationExportSettings_events {
    }
}
