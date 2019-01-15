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


namespace UE4.MovieSceneTools.Native {
    [StructLayout( LayoutKind.Explicit, Size=168 )]
    internal unsafe struct MovieSceneToolsProjectSettings_fields {
        [FieldOffset(56)] public float DefaultStartTime;
        [FieldOffset(60)] public float DefaultDuration;
        [FieldOffset(64)] byte ShotDirectory; //TODO: string FString ShotDirectory
        [FieldOffset(80)] byte ShotPrefix; //TODO: string FString ShotPrefix
        [FieldOffset(96)] byte FirstShotNumber; //TODO: numeric uint32 FirstShotNumber
        [FieldOffset(100)] byte ShotIncrement; //TODO: numeric uint32 ShotIncrement
        [FieldOffset(104)] byte ShotNumDigits; //TODO: numeric uint32 ShotNumDigits
        [FieldOffset(108)] byte TakeNumDigits; //TODO: numeric uint32 TakeNumDigits
        [FieldOffset(112)] byte FirstTakeNumber; //TODO: numeric uint32 FirstTakeNumber
        [FieldOffset(120)] byte TakeSeparator; //TODO: string FString TakeSeparator
        [FieldOffset(136)] byte SubSequenceSeparator; //TODO: string FString SubSequenceSeparator
        [FieldOffset(152)] public NativeArray FbxSettings;
    }
    internal unsafe struct MovieSceneToolsProjectSettings_methods {
    }
    internal unsafe struct MovieSceneToolsProjectSettings_events {
    }
}
