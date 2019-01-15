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


namespace UE4.Kismet.Native {
    [StructLayout( LayoutKind.Explicit, Size=128 )]
    internal unsafe struct BlueprintPaletteFavorites_fields {
        [FieldOffset(80)] public NativeArray CustomFavorites;
        [FieldOffset(96)] public NativeArray CurrentFavorites;
        [FieldOffset(112)] byte CurrentProfile; //TODO: string FString CurrentProfile
    }
    internal unsafe struct BlueprintPaletteFavorites_methods {
    }
    internal unsafe struct BlueprintPaletteFavorites_events {
    }
}
