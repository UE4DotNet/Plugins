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

#pragma warning disable CS0108
using UE4.HeadMountedDisplay.Native;
using UE4.Engine;

namespace UE4.HeadMountedDisplay {
    ///<summary>VRNotifications Component</summary>
    public unsafe partial class VRNotificationsComponent : ActorComponent  {
         //TODO: multicast delegate FVRNotificationsDelegate HMDTrackingInitializingAndNeedsHMDToBeTrackedDelegate
         //TODO: multicast delegate FVRNotificationsDelegate HMDTrackingInitializedDelegate
         //TODO: multicast delegate FVRNotificationsDelegate HMDRecenteredDelegate
         //TODO: multicast delegate FVRNotificationsDelegate HMDLostDelegate
         //TODO: multicast delegate FVRNotificationsDelegate HMDReconnectedDelegate
         //TODO: multicast delegate FVRNotificationsDelegate HMDConnectCanceledDelegate
         //TODO: multicast delegate FVRNotificationsDelegate HMDPutOnHeadDelegate
         //TODO: multicast delegate FVRNotificationsDelegate HMDRemovedFromHeadDelegate
         //TODO: multicast delegate FVRNotificationsDelegate VRControllerRecenteredDelegate
        static VRNotificationsComponent() {
            StaticClass = Main.GetClass("VRNotificationsComponent");
        }
        internal unsafe VRNotificationsComponent_fields* VRNotificationsComponent_ptr => (VRNotificationsComponent_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator VRNotificationsComponent(IntPtr p) => UObject.Make<VRNotificationsComponent>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static VRNotificationsComponent DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static VRNotificationsComponent New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
