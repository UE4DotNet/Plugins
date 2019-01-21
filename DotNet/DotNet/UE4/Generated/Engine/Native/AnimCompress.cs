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
    [StructLayout( LayoutKind.Explicit, Size=96 )]
    internal unsafe struct AnimCompress_fields {
        [FieldOffset(56)] byte Description; //TODO: string FString Description
        [FieldOffset(72)] public bool bNeedsSkeleton;
        [FieldOffset(72)] public bool bEnableSegmenting;
        [FieldOffset(76)] byte IdealNumFramesPerSegment; //TODO: numeric uint32 IdealNumFramesPerSegment
        [FieldOffset(80)] byte MaxNumFramesPerSegment; //TODO: numeric uint32 MaxNumFramesPerSegment
        [FieldOffset(84)] public byte TranslationCompressionFormat;
        [FieldOffset(85)] public byte RotationCompressionFormat;
        [FieldOffset(86)] public byte ScaleCompressionFormat;
        [FieldOffset(88)] public float MaxCurveError;
    }
    internal unsafe struct AnimCompress_methods {
    }
    internal unsafe struct AnimCompress_events {
    }
}
