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
using UE4.GameplayTasks.Native;

namespace UE4.GameplayTasks {
    ///<summary>Gameplay Task Resource</summary>
    public unsafe partial class GameplayTaskResource : UObject  {
        ///<summary>Overrides AutoResourceID. -1 means auto ID will be applied</summary>
        public unsafe int ManualResourceID {
            get {return GameplayTaskResource_ptr->ManualResourceID;}
        }
        ///<summary>Auto Resource ID</summary>
        public unsafe sbyte AutoResourceID {
            get {return GameplayTaskResource_ptr->AutoResourceID;}
            set {GameplayTaskResource_ptr->AutoResourceID = value;}
        }
        public bool bManuallySetID {
            get {return Main.GetGetBoolPropertyByName(this, "bManuallySetID"); }
            set {Main.SetGetBoolPropertyByName(this, "bManuallySetID", value); }
        }
        static GameplayTaskResource() {
            StaticClass = Main.GetClass("GameplayTaskResource");
        }
        internal unsafe GameplayTaskResource_fields* GameplayTaskResource_ptr => (GameplayTaskResource_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator GameplayTaskResource(IntPtr p) => UObject.Make<GameplayTaskResource>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static GameplayTaskResource DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static GameplayTaskResource New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
