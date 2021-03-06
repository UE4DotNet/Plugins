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
using UE4.AIModule.Native;
using UE4.NavigationSystem;

namespace UE4.AIModule {
    ///<summary>Nav Filter AIController Default</summary>
    public unsafe partial class NavFilter_AIControllerDefault : NavigationQueryFilter  {
        static NavFilter_AIControllerDefault() {
            StaticClass = Main.GetClass("NavFilter_AIControllerDefault");
        }
        internal unsafe NavFilter_AIControllerDefault_fields* NavFilter_AIControllerDefault_ptr => (NavFilter_AIControllerDefault_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator NavFilter_AIControllerDefault(IntPtr p) => UObject.Make<NavFilter_AIControllerDefault>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static NavFilter_AIControllerDefault DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static NavFilter_AIControllerDefault New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
