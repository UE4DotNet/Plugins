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


namespace UE4.MagicLeap.Native {
    [StructLayout( LayoutKind.Explicit, Size=720 )]
    internal unsafe struct ImageTrackerComponent_fields {
        [FieldOffset(624)] byte OnImageTargetFound; //TODO: multicast delegate FImageTargetFound OnImageTargetFound
        [FieldOffset(640)] byte OnImageTargetLost; //TODO: multicast delegate FImageTargetLost OnImageTargetLost
        [FieldOffset(656)] byte OnImageTargetUnreliableTracking; //TODO: multicast delegate FImageTargetUnreliableTracking OnImageTargetUnreliableTracking
        [FieldOffset(672)]  public IntPtr  TargetImageTexture;
        [FieldOffset(680)] byte Name; //TODO: string FString Name
        [FieldOffset(696)] public float LongerDimension;
        [FieldOffset(700)] public bool bIsStationary;
        [FieldOffset(701)] public bool bUseUnreliablePose;
    }
    internal unsafe struct ImageTrackerComponent_methods {
    }
    internal unsafe struct ImageTrackerComponent_events {
    }
}
