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


namespace UE4.MediaCompositing.Native {
    [StructLayout( LayoutKind.Explicit, Size=360 )]
    internal unsafe struct MovieSceneMediaSection_fields {
        [FieldOffset(312)] byte Proxy; //TODO: string FString Proxy
        [FieldOffset(328)]  public IntPtr  MediaSoundComponent;
        [FieldOffset(336)]  public IntPtr  MediaTexture;
        [FieldOffset(344)]  public IntPtr  MediaSource;
        [FieldOffset(352)] public float ThumbnailReferenceOffset;
    }
    internal unsafe struct MovieSceneMediaSection_methods {
    }
    internal unsafe struct MovieSceneMediaSection_events {
    }
}
