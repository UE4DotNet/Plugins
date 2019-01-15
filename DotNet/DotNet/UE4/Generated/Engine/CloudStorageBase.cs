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
    ///<summary>Base class for the various platform interface classes.</summary>
    public unsafe partial class CloudStorageBase : PlatformInterfaceBase  {
         //TODO: array not UObject TArray LocalCloudFiles
        public bool bSuppressDelegateCalls {
            get {return Main.GetGetBoolPropertyByName(this, "bSuppressDelegateCalls"); }
            set {Main.SetGetBoolPropertyByName(this, "bSuppressDelegateCalls", value); }
        }
        static CloudStorageBase() {
            StaticClass = Main.GetClass("CloudStorageBase");
        }
        internal unsafe CloudStorageBase_fields* CloudStorageBase_ptr => (CloudStorageBase_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator CloudStorageBase(IntPtr p) => UObject.Make<CloudStorageBase>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static CloudStorageBase DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static CloudStorageBase New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
