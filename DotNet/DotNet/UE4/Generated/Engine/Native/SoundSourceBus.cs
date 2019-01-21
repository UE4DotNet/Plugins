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
    [StructLayout( LayoutKind.Explicit, Size=784 )]
    internal unsafe struct SoundSourceBus_fields {
        [FieldOffset(760)] byte SourceBusChannels; //TODO: enum ESourceBusChannels SourceBusChannels
        [FieldOffset(764)] public float SourceBusDuration;
        [FieldOffset(768)] public bool bAutoDeactivateWhenSilent;
    }
    internal unsafe struct SoundSourceBus_methods {
    }
    internal unsafe struct SoundSourceBus_events {
    }
}
