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


namespace UE4.GameplayTags.Native {
    [StructLayout( LayoutKind.Explicit, Size=224 )]
    internal unsafe struct GameplayTagsSettings_fields {
        [FieldOffset(88)] public bool ImportTagsFromConfig;
        [FieldOffset(89)] public bool WarnOnInvalidTags;
        [FieldOffset(96)] public NativeArray CategoryRemapping;
        [FieldOffset(112)] public bool FastReplication;
        [FieldOffset(120)] public NativeArray GameplayTagTableList;
        [FieldOffset(136)] public NativeArray GameplayTagRedirects;
        [FieldOffset(152)] public NativeArray CommonlyReplicatedTags;
        [FieldOffset(168)] public int NumBitsForContainerSize;
        [FieldOffset(172)] public int NetIndexFirstBitSegment;
        [FieldOffset(176)] public NativeArray RestrictedConfigFiles;
        [FieldOffset(192)] byte RestrictedTagList; //TODO: string FString RestrictedTagList
    }
    internal unsafe struct GameplayTagsSettings_methods {
    }
    internal unsafe struct GameplayTagsSettings_events {
    }
}
