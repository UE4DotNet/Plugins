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
    ///<summary>Navigation System</summary>
    public unsafe partial class NavigationSystem : UObject  {

        ///<summary>Simple Move to Actor</summary>
        public static void SimpleMoveToActor(Controller Controller, Actor Goal)  => 
            NavigationSystem_methods.SimpleMoveToActor_method.Invoke(Controller, Goal);

        ///<summary>Simple Move to Location</summary>
        public static void SimpleMoveToLocation(Controller Controller, Vector Goal)  => 
            NavigationSystem_methods.SimpleMoveToLocation_method.Invoke(Controller, Goal);
        static NavigationSystem() {
            StaticClass = Main.GetClass("NavigationSystem");
        }
        internal unsafe NavigationSystem_fields* NavigationSystem_ptr => (NavigationSystem_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator NavigationSystem(IntPtr p) => UObject.Make<NavigationSystem>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static NavigationSystem DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static NavigationSystem New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
