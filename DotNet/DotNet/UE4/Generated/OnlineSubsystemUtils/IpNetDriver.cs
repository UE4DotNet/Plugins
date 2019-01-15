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
    ///<summary>Ip Net Driver</summary>
    public unsafe partial class IpNetDriver : NetDriver  {
        public bool LogPortUnreach {
            get {return Main.GetGetBoolPropertyByName(this, "LogPortUnreach"); }
            set {Main.SetGetBoolPropertyByName(this, "LogPortUnreach", value); }
        }
        public bool AllowPlayerPortUnreach {
            get {return Main.GetGetBoolPropertyByName(this, "AllowPlayerPortUnreach"); }
            set {Main.SetGetBoolPropertyByName(this, "AllowPlayerPortUnreach", value); }
        }
         //TODO: numeric uint32 MaxPortCountToTry
         //TODO: numeric uint32 ServerDesiredSocketReceiveBufferBytes
         //TODO: numeric uint32 ServerDesiredSocketSendBufferBytes
         //TODO: numeric uint32 ClientDesiredSocketReceiveBufferBytes
         //TODO: numeric uint32 ClientDesiredSocketSendBufferBytes
        static IpNetDriver() {
            StaticClass = Main.GetClass("IpNetDriver");
        }
        internal unsafe IpNetDriver_fields* IpNetDriver_ptr => (IpNetDriver_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator IpNetDriver(IntPtr p) => UObject.Make<IpNetDriver>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static IpNetDriver DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static IpNetDriver New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
