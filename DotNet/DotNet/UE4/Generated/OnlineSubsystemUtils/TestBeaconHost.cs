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

namespace UE4.OnlineSubsystemUtils {
    ///<summary>A beacon host used for taking reservations for an existing game session</summary>
    public unsafe partial class TestBeaconHost : OnlineBeaconHostObject  {
        static TestBeaconHost() {
            StaticClass = Main.GetClass("TestBeaconHost");
        }
        internal unsafe TestBeaconHost_fields* TestBeaconHost_ptr => (TestBeaconHost_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator TestBeaconHost(IntPtr p) => UObject.Make<TestBeaconHost>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static TestBeaconHost DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static TestBeaconHost New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
