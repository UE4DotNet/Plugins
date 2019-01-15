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

namespace UE4.MovieScene.Native {
    [StructLayout( LayoutKind.Explicit, Size=440 )]
    internal unsafe struct MovieSceneSubSection_fields {
        [FieldOffset(312)] public MovieSceneSectionParameters Parameters;
        [FieldOffset(352)]  public IntPtr  SubSequence;
        [FieldOffset(360)] byte ActorToRecord; //TODO: lazy_object TLazyObjectPtr<AActor> ActorToRecord
        [FieldOffset(392)] byte TargetSequenceName; //TODO: string FString TargetSequenceName
        [FieldOffset(408)] public DirectoryPath TargetPathToRecordTo;
    }
    internal unsafe struct MovieSceneSubSection_methods {
    }
    internal unsafe struct MovieSceneSubSection_events {
    }
}
