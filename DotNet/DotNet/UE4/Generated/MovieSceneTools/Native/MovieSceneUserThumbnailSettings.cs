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


namespace UE4.MovieSceneTools.Native {
    [StructLayout( LayoutKind.Explicit, Size=96 )]
    internal unsafe struct MovieSceneUserThumbnailSettings_fields {
        [FieldOffset(56)] public bool bDrawThumbnails;
        [FieldOffset(57)] public bool bDrawSingleThumbnails;
        [FieldOffset(60)] public IntPoint ThumbnailSize;
        [FieldOffset(68)] byte Quality; //TODO: enum EThumbnailQuality Quality
    }
    internal unsafe struct MovieSceneUserThumbnailSettings_methods {
    }
    internal unsafe struct MovieSceneUserThumbnailSettings_events {
    }
}
