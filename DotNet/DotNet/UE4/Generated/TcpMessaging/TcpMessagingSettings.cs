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
using UE4.TcpMessaging.Native;

namespace UE4.TcpMessaging {
    ///<summary>Tcp Messaging Settings</summary>
    public unsafe partial class TcpMessagingSettings : UObject  {
        public bool EnableTransport {
            get {return Main.GetGetBoolPropertyByName(this, "EnableTransport"); }
            set {Main.SetGetBoolPropertyByName(this, "EnableTransport", value); }
        }
         //TODO: string FString ListenEndpoint
         //TODO: array not UObject TArray ConnectToEndpoints
        ///<summary>Delay time between attempts to re-establish outgoing connections that become disconnected or fail to connect</summary>
        ///<remarks>0 disables reconnection</remarks>
        public unsafe int ConnectionRetryDelay {
            get {return TcpMessagingSettings_ptr->ConnectionRetryDelay;}
            set {TcpMessagingSettings_ptr->ConnectionRetryDelay = value;}
        }
        static TcpMessagingSettings() {
            StaticClass = Main.GetClass("TcpMessagingSettings");
        }
        internal unsafe TcpMessagingSettings_fields* TcpMessagingSettings_ptr => (TcpMessagingSettings_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator TcpMessagingSettings(IntPtr p) => UObject.Make<TcpMessagingSettings>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static TcpMessagingSettings DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static TcpMessagingSettings New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
