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
    [StructLayout( LayoutKind.Explicit, Size=144 )]
    internal unsafe struct DialogueWave_fields {
        [FieldOffset(56)] public bool bMature;
        [FieldOffset(56)] public bool bOverride_SubtitleOverride;
        [FieldOffset(64)] byte SpokenText; //TODO: string FString SpokenText
        [FieldOffset(80)] byte SubtitleOverride; //TODO: string FString SubtitleOverride
        [FieldOffset(96)] byte VoiceActorDirection; //TODO: string FString VoiceActorDirection
        [FieldOffset(112)] public NativeArray ContextMappings;
        [FieldOffset(128)] public FGuid LocalizationGUID;
    }
    internal unsafe struct DialogueWave_methods {
    }
    internal unsafe struct DialogueWave_events {
    }
}
