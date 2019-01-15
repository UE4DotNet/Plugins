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


namespace UE4.HeadMountedDisplay.Native {
    [StructLayout( LayoutKind.Explicit, Size=400 )]
    internal unsafe struct VRNotificationsComponent_fields {
        [FieldOffset(256)] byte HMDTrackingInitializingAndNeedsHMDToBeTrackedDelegate; //TODO: multicast delegate FVRNotificationsDelegate HMDTrackingInitializingAndNeedsHMDToBeTrackedDelegate
        [FieldOffset(272)] byte HMDTrackingInitializedDelegate; //TODO: multicast delegate FVRNotificationsDelegate HMDTrackingInitializedDelegate
        [FieldOffset(288)] byte HMDRecenteredDelegate; //TODO: multicast delegate FVRNotificationsDelegate HMDRecenteredDelegate
        [FieldOffset(304)] byte HMDLostDelegate; //TODO: multicast delegate FVRNotificationsDelegate HMDLostDelegate
        [FieldOffset(320)] byte HMDReconnectedDelegate; //TODO: multicast delegate FVRNotificationsDelegate HMDReconnectedDelegate
        [FieldOffset(336)] byte HMDConnectCanceledDelegate; //TODO: multicast delegate FVRNotificationsDelegate HMDConnectCanceledDelegate
        [FieldOffset(352)] byte HMDPutOnHeadDelegate; //TODO: multicast delegate FVRNotificationsDelegate HMDPutOnHeadDelegate
        [FieldOffset(368)] byte HMDRemovedFromHeadDelegate; //TODO: multicast delegate FVRNotificationsDelegate HMDRemovedFromHeadDelegate
        [FieldOffset(384)] byte VRControllerRecenteredDelegate; //TODO: multicast delegate FVRNotificationsDelegate VRControllerRecenteredDelegate
    }
    internal unsafe struct VRNotificationsComponent_methods {
    }
    internal unsafe struct VRNotificationsComponent_events {
    }
}
