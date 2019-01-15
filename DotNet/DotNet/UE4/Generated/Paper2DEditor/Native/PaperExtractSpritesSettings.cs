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


namespace UE4.Paper2DEditor.Native {
    [StructLayout( LayoutKind.Explicit, Size=136 )]
    internal unsafe struct PaperExtractSpritesSettings_fields {
        [FieldOffset(56)] byte SpriteExtractMode; //TODO: enum ESpriteExtractMode SpriteExtractMode
        [FieldOffset(60)] public LinearColor OutlineColor;
        [FieldOffset(76)] public LinearColor ViewportTextureTint;
        [FieldOffset(92)] public LinearColor BackgroundColor;
        [FieldOffset(112)] byte NamingTemplate; //TODO: string FString NamingTemplate
        [FieldOffset(128)] public int NamingStartIndex;
    }
    internal unsafe struct PaperExtractSpritesSettings_methods {
    }
    internal unsafe struct PaperExtractSpritesSettings_events {
    }
}
