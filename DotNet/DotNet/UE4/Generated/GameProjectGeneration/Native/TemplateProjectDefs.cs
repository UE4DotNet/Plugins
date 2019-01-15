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


namespace UE4.GameProjectGeneration.Native {
    [StructLayout( LayoutKind.Explicit, Size=280 )]
    internal unsafe struct TemplateProjectDefs_fields {
        [FieldOffset(56)] public NativeArray LocalizedDisplayNames;
        [FieldOffset(72)] public NativeArray LocalizedDescriptions;
        [FieldOffset(88)] public NativeArray FoldersToIgnore;
        [FieldOffset(104)] public NativeArray FilesToIgnore;
        [FieldOffset(120)] public NativeArray FolderRenames;
        [FieldOffset(136)] public NativeArray FilenameReplacements;
        [FieldOffset(152)] public NativeArray ReplacementsInFiles;
        [FieldOffset(168)] byte SortKey; //TODO: string FString SortKey
        [FieldOffset(184)] public Name Category;
        [FieldOffset(200)] byte ClassTypes; //TODO: string FString ClassTypes
        [FieldOffset(216)] byte AssetTypes; //TODO: string FString AssetTypes
        [FieldOffset(232)] public bool bAllowProjectCreation;
        [FieldOffset(240)] public NativeArray PacksToInclude;
        [FieldOffset(256)] byte EditDetailLevelPreference; //TODO: enum EFeaturePackDetailLevel EditDetailLevelPreference
        [FieldOffset(264)] public NativeArray SharedContentPacks;
    }
    internal unsafe struct TemplateProjectDefs_methods {
    }
    internal unsafe struct TemplateProjectDefs_events {
    }
}
