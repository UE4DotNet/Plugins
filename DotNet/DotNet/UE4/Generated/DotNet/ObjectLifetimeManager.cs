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
using UE4.DotNet.Native;

namespace UE4.DotNet {
    ///<summary>Object Lifetime Manager</summary>
    public unsafe partial class ObjectLifetimeManager : UObject  {
        ///<summary>CLRObjects</summary>
        public ObjectArrayField<UObject> CLRObjects{ get {
            if(CLRObjects_store == null) CLRObjects_store = new ObjectArrayField<UObject> (&ObjectLifetimeManager_ptr->CLRObjects);
            return CLRObjects_store;
        } }
        private ObjectArrayField<UObject> CLRObjects_store;

        static ObjectLifetimeManager() {
            StaticClass = Main.GetClass("ObjectLifetimeManager");
        }
        internal unsafe ObjectLifetimeManager_fields* ObjectLifetimeManager_ptr => (ObjectLifetimeManager_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator ObjectLifetimeManager(IntPtr p) => UObject.Make<ObjectLifetimeManager>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static ObjectLifetimeManager DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static ObjectLifetimeManager New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
