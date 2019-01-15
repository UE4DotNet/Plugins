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
    ///<summary>Online Engine Interface Impl</summary>
    public unsafe partial class OnlineEngineInterfaceImpl : OnlineEngineInterface  {
        ///<summary>Allow the subsystem used for voice functions to be overridden, in case it needs to be different than the default subsystem. May be useful on console platforms.</summary>
        public unsafe Name VoiceSubsystemNameOverride {
            get {return OnlineEngineInterfaceImpl_ptr->VoiceSubsystemNameOverride;}
            set {OnlineEngineInterfaceImpl_ptr->VoiceSubsystemNameOverride = value;}
        }
        static OnlineEngineInterfaceImpl() {
            StaticClass = Main.GetClass("OnlineEngineInterfaceImpl");
        }
        internal unsafe OnlineEngineInterfaceImpl_fields* OnlineEngineInterfaceImpl_ptr => (OnlineEngineInterfaceImpl_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator OnlineEngineInterfaceImpl(IntPtr p) => UObject.Make<OnlineEngineInterfaceImpl>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static OnlineEngineInterfaceImpl DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static OnlineEngineInterfaceImpl New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
