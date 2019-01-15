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
using UE4.UdpMessaging.Native;

namespace UE4.UdpMessaging {
    ///<summary>Udp Messaging Settings</summary>
    public unsafe partial class UdpMessagingSettings : UObject  {
        public bool EnableTransport {
            get {return Main.GetGetBoolPropertyByName(this, "EnableTransport"); }
            set {Main.SetGetBoolPropertyByName(this, "EnableTransport", value); }
        }
         //TODO: string FString UnicastEndpoint
         //TODO: string FString MulticastEndpoint
        ///<summary>The time-to-live (TTL) for sent multicast packets.</summary>
        public unsafe byte MulticastTimeToLive {
            get {return UdpMessagingSettings_ptr->MulticastTimeToLive;}
            set {UdpMessagingSettings_ptr->MulticastTimeToLive = value;}
        }
         //TODO: array not UObject TArray StaticEndpoints
        public bool EnableTunnel {
            get {return Main.GetGetBoolPropertyByName(this, "EnableTunnel"); }
            set {Main.SetGetBoolPropertyByName(this, "EnableTunnel", value); }
        }
         //TODO: string FString TunnelUnicastEndpoint
         //TODO: string FString TunnelMulticastEndpoint
         //TODO: array not UObject TArray RemoteTunnelEndpoints
        static UdpMessagingSettings() {
            StaticClass = Main.GetClass("UdpMessagingSettings");
        }
        internal unsafe UdpMessagingSettings_fields* UdpMessagingSettings_ptr => (UdpMessagingSettings_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator UdpMessagingSettings(IntPtr p) => UObject.Make<UdpMessagingSettings>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static UdpMessagingSettings DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static UdpMessagingSettings New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
