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


namespace UE4.NavigationSystem.Native {
    [StructLayout( LayoutKind.Explicit, Size=472 )]
    internal unsafe struct NavLinkCustomComponent_fields {
        [FieldOffset(312)] byte NavLinkUserId; //TODO: numeric uint32 NavLinkUserId
        [FieldOffset(320)] public IntPtr EnabledAreaClass;
        [FieldOffset(328)] public IntPtr DisabledAreaClass;
        [FieldOffset(336)] public Vector LinkRelativeStart;
        [FieldOffset(348)] public Vector LinkRelativeEnd;
        [FieldOffset(360)] public byte LinkDirection;
        [FieldOffset(364)] public bool bLinkEnabled;
        [FieldOffset(364)] public bool bNotifyWhenEnabled;
        [FieldOffset(364)] public bool bNotifyWhenDisabled;
        [FieldOffset(364)] public bool bCreateBoxObstacle;
        [FieldOffset(368)] public Vector ObstacleOffset;
        [FieldOffset(380)] public Vector ObstacleExtent;
        [FieldOffset(392)] public IntPtr ObstacleAreaClass;
        [FieldOffset(400)] public float BroadcastRadius;
        [FieldOffset(404)] public float BroadcastInterval;
        [FieldOffset(408)] public byte BroadcastChannel;
    }
    internal unsafe struct NavLinkCustomComponent_methods {
    }
    internal unsafe struct NavLinkCustomComponent_events {
    }
}
