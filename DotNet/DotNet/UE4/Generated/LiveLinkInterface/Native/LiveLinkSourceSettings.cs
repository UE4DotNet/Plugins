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


namespace UE4.LiveLinkInterface.Native {
    [StructLayout( LayoutKind.Explicit, Size=80 )]
    internal unsafe struct LiveLinkSourceSettings_fields {
        [FieldOffset(56)] byte Mode; //TODO: enum ELiveLinkSourceMode Mode
        [FieldOffset(60)] public LiveLinkInterpolationSettings InterpolationSettings;
        [FieldOffset(68)] public LiveLinkTimeSynchronizationSettings TimeSynchronizationSettings;
    }
    internal unsafe struct LiveLinkSourceSettings_methods {
    }
    internal unsafe struct LiveLinkSourceSettings_events {
    }
}
