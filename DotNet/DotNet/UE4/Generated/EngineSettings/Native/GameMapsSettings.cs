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


namespace UE4.EngineSettings.Native {
    [StructLayout( LayoutKind.Explicit, Size=336 )]
    internal unsafe struct GameMapsSettings_fields {
        [FieldOffset(56)] public SoftObjectPath EditorStartupMap;
        [FieldOffset(88)] byte LocalMapOptions; //TODO: string FString LocalMapOptions
        [FieldOffset(104)] public SoftObjectPath TransitionMap;
        [FieldOffset(136)] public bool bUseSplitscreen;
        [FieldOffset(137)] public byte TwoPlayerSplitscreenLayout;
        [FieldOffset(138)] public byte ThreePlayerSplitscreenLayout;
        [FieldOffset(139)] byte FourPlayerSplitscreenLayout; //TODO: enum EFourPlayerSplitScreenType FourPlayerSplitscreenLayout
        [FieldOffset(140)] public bool bOffsetPlayerGamepadIds;
        [FieldOffset(144)] public SoftClassPath GameInstanceClass;
        [FieldOffset(176)] public SoftObjectPath GameDefaultMap;
        [FieldOffset(208)] public SoftObjectPath ServerDefaultMap;
        [FieldOffset(240)] public SoftClassPath GlobalDefaultGameMode;
        [FieldOffset(272)] public SoftClassPath GlobalDefaultServerGameMode;
        [FieldOffset(304)] public NativeArray GameModeMapPrefixes;
        [FieldOffset(320)] public NativeArray GameModeClassAliases;
    }
    internal unsafe struct GameMapsSettings_methods {
    }
    internal unsafe struct GameMapsSettings_events {
    }
}
