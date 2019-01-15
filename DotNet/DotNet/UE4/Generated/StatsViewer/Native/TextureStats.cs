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


namespace UE4.StatsViewer.Native {
    [StructLayout( LayoutKind.Explicit, Size=152 )]
    internal unsafe struct TextureStats_fields {
        [FieldOffset(56)] byte Texture; //TODO: weak object TWeakObjectPtr<UTexture> Texture
        [FieldOffset(64)] public NativeArray Actors;
        [FieldOffset(80)] byte Type; //TODO: string FString Type
        [FieldOffset(96)] public Vector2D MaxDim;
        [FieldOffset(104)] public Vector2D CurrentDim;
        [FieldOffset(112)] public byte Format;
        [FieldOffset(113)] public byte Group;
        [FieldOffset(116)] public int LODBias;
        [FieldOffset(120)] public float CurrentKB;
        [FieldOffset(124)] public float FullyLoadedKB;
        [FieldOffset(128)] public int NumUses;
        [FieldOffset(132)] public float LastTimeRendered;
        [FieldOffset(136)] byte Path; //TODO: string FString Path
    }
    internal unsafe struct TextureStats_methods {
    }
    internal unsafe struct TextureStats_events {
    }
}
