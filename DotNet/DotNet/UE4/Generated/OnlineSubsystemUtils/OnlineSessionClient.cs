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
    ///<summary>Online Session Client</summary>
    public unsafe partial class OnlineSessionClient : OnlineSession  {
        public bool bIsFromInvite {
            get {return Main.GetGetBoolPropertyByName(this, "bIsFromInvite"); }
            set {Main.SetGetBoolPropertyByName(this, "bIsFromInvite", value); }
        }
        public bool bHandlingDisconnect {
            get {return Main.GetGetBoolPropertyByName(this, "bHandlingDisconnect"); }
            set {Main.SetGetBoolPropertyByName(this, "bHandlingDisconnect", value); }
        }
        static OnlineSessionClient() {
            StaticClass = Main.GetClass("OnlineSessionClient");
        }
        internal unsafe OnlineSessionClient_fields* OnlineSessionClient_ptr => (OnlineSessionClient_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator OnlineSessionClient(IntPtr p) => UObject.Make<OnlineSessionClient>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static OnlineSessionClient DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static OnlineSessionClient New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
