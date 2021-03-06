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
    ///<summary>Device Profile</summary>
    public unsafe partial class DeviceProfile : TextureLODSettings  {
         //TODO: string FString DeviceType
         //TODO: string FString BaseProfileName
        ///<summary>The parent object of this profile, it is the object matching this DeviceType with the BaseProfileName</summary>
        public unsafe UObject Parent {
            get {return DeviceProfile_ptr->Parent;}
            set {DeviceProfile_ptr->Parent = value;}
        }
         //TODO: array not UObject TArray CVars
        static DeviceProfile() {
            StaticClass = Main.GetClass("DeviceProfile");
        }
        internal unsafe DeviceProfile_fields* DeviceProfile_ptr => (DeviceProfile_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator DeviceProfile(IntPtr p) => UObject.Make<DeviceProfile>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static DeviceProfile DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static DeviceProfile New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
