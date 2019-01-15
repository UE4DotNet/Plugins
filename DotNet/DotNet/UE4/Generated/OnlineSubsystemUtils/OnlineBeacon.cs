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
using UE4.OnlineSubsystemUtils.Native;
using UE4.Engine;

namespace UE4.OnlineSubsystemUtils {
    ///<summary>Base class for beacon communication (Unreal Networking, but outside normal gameplay traffic)</summary>
    public unsafe partial class OnlineBeacon : Actor  {
        ///<summary>Time beacon will wait to establish a connection with the beacon host</summary>
        public unsafe float BeaconConnectionInitialTimeout {
            get {return OnlineBeacon_ptr->BeaconConnectionInitialTimeout;}
            set {OnlineBeacon_ptr->BeaconConnectionInitialTimeout = value;}
        }
        ///<summary>Time beacon will wait for packets after establishing a connection before giving up</summary>
        public unsafe float BeaconConnectionTimeout {
            get {return OnlineBeacon_ptr->BeaconConnectionTimeout;}
            set {OnlineBeacon_ptr->BeaconConnectionTimeout = value;}
        }
        ///<summary>Net driver routing network traffic</summary>
        public unsafe NetDriver NetDriver {
            get {return OnlineBeacon_ptr->NetDriver;}
            set {OnlineBeacon_ptr->NetDriver = value;}
        }
        static OnlineBeacon() {
            StaticClass = Main.GetClass("OnlineBeacon");
        }
        internal unsafe OnlineBeacon_fields* OnlineBeacon_ptr => (OnlineBeacon_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator OnlineBeacon(IntPtr p) => UObject.Make<OnlineBeacon>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static OnlineBeacon DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static OnlineBeacon New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
