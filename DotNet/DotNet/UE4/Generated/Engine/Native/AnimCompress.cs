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
    [StructLayout( LayoutKind.Explicit, Size=88 )]
    internal unsafe struct AnimCompress_fields {
        [FieldOffset(56)] byte Description; //TODO: string FString Description
        [FieldOffset(72)] public bool bNeedsSkeleton;
        [FieldOffset(76)] public byte TranslationCompressionFormat;
        [FieldOffset(77)] public byte RotationCompressionFormat;
        [FieldOffset(78)] public byte ScaleCompressionFormat;
        [FieldOffset(80)] public float MaxCurveError;
    }
    internal unsafe struct AnimCompress_methods {
    }
    internal unsafe struct AnimCompress_events {
    }
}
