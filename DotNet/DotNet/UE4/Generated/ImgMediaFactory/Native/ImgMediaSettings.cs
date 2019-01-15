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


namespace UE4.ImgMediaFactory.Native {
    [StructLayout( LayoutKind.Explicit, Size=112 )]
    internal unsafe struct ImgMediaSettings_fields {
        [FieldOffset(56)] public FrameRate DefaultFrameRate;
        [FieldOffset(64)] public float CacheBehindPercentage;
        [FieldOffset(68)] public float CacheSizeGB;
        [FieldOffset(72)] public int CacheThreads;
        [FieldOffset(76)] public int CacheThreadStackSizeKB;
        [FieldOffset(80)] byte ExrDecoderThreads; //TODO: numeric uint32 ExrDecoderThreads
        [FieldOffset(88)] byte DefaultProxy; //TODO: string FString DefaultProxy
        [FieldOffset(104)] public bool UseDefaultProxy;
    }
    internal unsafe struct ImgMediaSettings_methods {
    }
    internal unsafe struct ImgMediaSettings_events {
    }
}
