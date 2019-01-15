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
using UE4.Engine.Native;

namespace UE4.Engine {
    ///<summary>Network settings.</summary>
    public unsafe partial class NetworkSettings : DeveloperSettings  {
        public bool bVerifyPeer {
            get {return Main.GetGetBoolPropertyByName(this, "bVerifyPeer"); }
            set {Main.SetGetBoolPropertyByName(this, "bVerifyPeer", value); }
        }
        public bool bEnableMultiplayerWorldOriginRebasing {
            get {return Main.GetGetBoolPropertyByName(this, "bEnableMultiplayerWorldOriginRebasing"); }
            set {Main.SetGetBoolPropertyByName(this, "bEnableMultiplayerWorldOriginRebasing", value); }
        }
        ///<summary>Maximum allowable size for replicated dynamic arrays (in number of elements). Must be between 1 and 65535.</summary>
        public unsafe int MaxRepArraySize {
            get {return NetworkSettings_ptr->MaxRepArraySize;}
            set {NetworkSettings_ptr->MaxRepArraySize = value;}
        }
        ///<summary>Maximum allowable size for replicated dynamic arrays (in bytes).  Must be between 1 and 65535.</summary>
        public unsafe int MaxRepArrayMemory {
            get {return NetworkSettings_ptr->MaxRepArrayMemory;}
            set {NetworkSettings_ptr->MaxRepArrayMemory = value;}
        }
        static NetworkSettings() {
            StaticClass = Main.GetClass("NetworkSettings");
        }
        internal unsafe NetworkSettings_fields* NetworkSettings_ptr => (NetworkSettings_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator NetworkSettings(IntPtr p) => UObject.Make<NetworkSettings>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static NetworkSettings DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static NetworkSettings New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
