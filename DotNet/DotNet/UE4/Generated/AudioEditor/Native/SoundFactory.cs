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
    [StructLayout( LayoutKind.Explicit, Size=152 )]
    internal unsafe struct SoundFactory_fields {
        [FieldOffset(128)] public bool bAutoCreateCue;
        [FieldOffset(128)] public bool bIncludeAttenuationNode;
        [FieldOffset(128)] public bool bIncludeLoopingNode;
        [FieldOffset(128)] public bool bIncludeModulatorNode;
        [FieldOffset(132)] public float CueVolume;
        [FieldOffset(136)] byte CuePackageSuffix; //TODO: string FString CuePackageSuffix
    }
    internal unsafe struct SoundFactory_methods {
    }
    internal unsafe struct SoundFactory_events {
    }
}
