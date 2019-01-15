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
using UE4.OnlineSubsystem.Native;

namespace UE4.OnlineSubsystem {
    ///<summary>Named interfaces are a registry of UObjects accessible by an FName key that will persist for the lifetime of the process</summary>
    public unsafe partial class NamedInterfaces : UObject  {
         //TODO: array not UObject TArray NamedInterfaces_
         //TODO: array not UObject TArray NamedInterfaceDefs
        static NamedInterfaces() {
            StaticClass = Main.GetClass("NamedInterfaces");
        }
        internal unsafe NamedInterfaces_fields* NamedInterfaces_ptr => (NamedInterfaces_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator NamedInterfaces(IntPtr p) => UObject.Make<NamedInterfaces>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static NamedInterfaces DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static NamedInterfaces New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
