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

using UE4.GameplayTags;

namespace UE4.AIModule.Native {
    [StructLayout( LayoutKind.Explicit, Size=232 )]
    internal unsafe struct BTDecorator_CheckGameplayTagsOnActor_fields {
        [FieldOffset(128)] public BlackboardKeySelector ActorToCheck;
        [FieldOffset(176)] byte TagsToMatch; //TODO: enum EGameplayContainerMatchType TagsToMatch
        [FieldOffset(184)] public GameplayTagContainer GameplayTags;
        [FieldOffset(216)] byte CachedDescription; //TODO: string FString CachedDescription
    }
    internal unsafe struct BTDecorator_CheckGameplayTagsOnActor_methods {
    }
    internal unsafe struct BTDecorator_CheckGameplayTagsOnActor_events {
    }
}
