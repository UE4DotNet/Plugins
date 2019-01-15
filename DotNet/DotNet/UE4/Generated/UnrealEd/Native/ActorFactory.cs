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
    [StructLayout( LayoutKind.Explicit, Size=128 )]
    internal unsafe struct ActorFactory_fields {
        [FieldOffset(56)] byte DisplayName; //TODO: text FText DisplayName
        [FieldOffset(80)] public int MenuPriority;
        [FieldOffset(88)] byte NewActorClassName; //TODO: string FString NewActorClassName
        [FieldOffset(104)] public IntPtr NewActorClass;
        [FieldOffset(112)] public bool bShowInEditorQuickMenu;
        [FieldOffset(112)] public bool bUseSurfaceOrientation;
        [FieldOffset(116)] public Vector SpawnPositionOffset;
    }
    internal unsafe struct ActorFactory_methods {
    }
    internal unsafe struct ActorFactory_events {
    }
}
