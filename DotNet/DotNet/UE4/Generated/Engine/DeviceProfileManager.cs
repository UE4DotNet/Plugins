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
    ///<summary>Implements a helper class that manages all profiles in the Device</summary>
    public unsafe partial class DeviceProfileManager : UObject  {
        ///<summary>Holds the collection of managed profiles.</summary>
        public ObjectArrayField<UObject> Profiles{ get {
            if(Profiles_store == null) Profiles_store = new ObjectArrayField<UObject> (&DeviceProfileManager_ptr->Profiles);
            return Profiles_store;
        } }
        private ObjectArrayField<UObject> Profiles_store;

        static DeviceProfileManager() {
            StaticClass = Main.GetClass("DeviceProfileManager");
        }
        internal unsafe DeviceProfileManager_fields* DeviceProfileManager_ptr => (DeviceProfileManager_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator DeviceProfileManager(IntPtr p) => UObject.Make<DeviceProfileManager>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static DeviceProfileManager DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static DeviceProfileManager New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
