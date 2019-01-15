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
    [StructLayout( LayoutKind.Explicit, Size=672 )]
    internal unsafe struct EnvQueryTest_GameplayTags_fields {
        [FieldOffset(560)] public GameplayTagQuery TagQueryToMatch;
        [FieldOffset(632)] public bool bUpdatedToUseQuery;
        [FieldOffset(633)] byte TagsToMatch; //TODO: enum EGameplayContainerMatchType TagsToMatch
        [FieldOffset(640)] public GameplayTagContainer GameplayTags;
    }
    internal unsafe struct EnvQueryTest_GameplayTags_methods {
    }
    internal unsafe struct EnvQueryTest_GameplayTags_events {
    }
}
