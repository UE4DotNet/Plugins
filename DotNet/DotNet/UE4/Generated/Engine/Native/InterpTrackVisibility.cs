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
    [StructLayout( LayoutKind.Explicit, Size=200 )]
    internal unsafe struct InterpTrackVisibility_fields {
        [FieldOffset(176)] public NativeArray VisibilityTrack;
        [FieldOffset(192)] public bool bFireEventsWhenForwards;
        [FieldOffset(192)] public bool bFireEventsWhenBackwards;
        [FieldOffset(192)] public bool bFireEventsWhenJumpingForwards;
    }
    internal unsafe struct InterpTrackVisibility_methods {
    }
    internal unsafe struct InterpTrackVisibility_events {
    }
}
