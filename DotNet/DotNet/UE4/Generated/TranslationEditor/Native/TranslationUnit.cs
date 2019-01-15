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


namespace UE4.TranslationEditor.Native {
    [StructLayout( LayoutKind.Explicit, Size=216 )]
    internal unsafe struct TranslationUnit_fields {
        [FieldOffset(56)] byte Namespace; //TODO: string FString Namespace
        [FieldOffset(72)] byte Key; //TODO: string FString Key
        [FieldOffset(88)] byte Source; //TODO: string FString Source
        [FieldOffset(104)] byte Translation; //TODO: string FString Translation
        [FieldOffset(120)] public NativeArray Contexts;
        [FieldOffset(136)] public bool HasBeenReviewed;
        [FieldOffset(144)] byte TranslationBeforeImport; //TODO: string FString TranslationBeforeImport
        [FieldOffset(160)] byte LocresPath; //TODO: string FString LocresPath
    }
    internal unsafe struct TranslationUnit_methods {
    }
    internal unsafe struct TranslationUnit_events {
    }
}
