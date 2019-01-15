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
    [StructLayout( LayoutKind.Explicit, Size=136 )]
    internal unsafe struct FontFace_fields {
        [FieldOffset(64)] byte SourceFilename; //TODO: string FString SourceFilename
        [FieldOffset(80)] byte Hinting; //TODO: enum EFontHinting Hinting
        [FieldOffset(81)] byte LoadingPolicy; //TODO: enum EFontLoadingPolicy LoadingPolicy
        [FieldOffset(82)] byte LayoutMethod; //TODO: enum EFontLayoutMethod LayoutMethod
        [FieldOffset(120)] public NativeArray SubFaces;
    }
    internal unsafe struct FontFace_methods {
    }
    internal unsafe struct FontFace_events {
    }
}
