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


namespace UE4.AudioEditor.Native {
    [StructLayout( LayoutKind.Explicit, Size=168 )]
    internal unsafe struct DialogueWaveFactory_fields {
        [FieldOffset(128)]  public IntPtr  InitialSoundWave;
        [FieldOffset(136)]  public IntPtr  InitialSpeakerVoice;
        [FieldOffset(144)] public bool HasSetInitialTargetVoice;
        [FieldOffset(152)] public NativeArray InitialTargetVoices;
    }
    internal unsafe struct DialogueWaveFactory_methods {
    }
    internal unsafe struct DialogueWaveFactory_events {
    }
}
