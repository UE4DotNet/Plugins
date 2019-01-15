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
    [StructLayout( LayoutKind.Explicit, Size=144 )]
    internal unsafe struct SoundNodeWavePlayer_fields {
        [FieldOffset(80)] byte SoundWaveAssetPtr; //TODO: soft object TSoftObjectPtr<USoundWave> SoundWaveAssetPtr
        [FieldOffset(128)]  public IntPtr  SoundWave;
        [FieldOffset(136)] public bool bLooping;
    }
    internal unsafe struct SoundNodeWavePlayer_methods {
    }
    internal unsafe struct SoundNodeWavePlayer_events {
    }
}
