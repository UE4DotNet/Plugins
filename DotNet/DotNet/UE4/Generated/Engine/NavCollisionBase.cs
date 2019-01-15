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
    ///<summary>Nav Collision Base</summary>
    public unsafe partial class NavCollisionBase : UObject  {
        public bool bIsDynamicObstacle {
            get {return Main.GetGetBoolPropertyByName(this, "bIsDynamicObstacle"); }
            set {Main.SetGetBoolPropertyByName(this, "bIsDynamicObstacle", value); }
        }
        static NavCollisionBase() {
            StaticClass = Main.GetClass("NavCollisionBase");
        }
        internal unsafe NavCollisionBase_fields* NavCollisionBase_ptr => (NavCollisionBase_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator NavCollisionBase(IntPtr p) => UObject.Make<NavCollisionBase>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static NavCollisionBase DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static NavCollisionBase New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
