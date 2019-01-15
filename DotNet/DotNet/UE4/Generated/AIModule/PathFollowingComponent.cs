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
using UE4.Engine;
using UE4.NavigationSystem;

namespace UE4.AIModule {
    ///<summary>Path Following Component</summary>
    public unsafe partial class PathFollowingComponent : ActorComponent  {

        ///<summary>Get Path Action Type</summary>
        public byte GetPathActionType()  => 
            PathFollowingComponent_methods.GetPathActionType_method.Invoke(ObjPointer);

        ///<summary>Get Path Destination</summary>
        public Vector GetPathDestination()  => 
            PathFollowingComponent_methods.GetPathDestination_method.Invoke(ObjPointer);
        ///<summary>associated movement component</summary>
        public unsafe NavMovementComponent MovementComp {
            get {return PathFollowingComponent_ptr->MovementComp;}
            set {PathFollowingComponent_ptr->MovementComp = value;}
        }
        ///<summary>navigation data for agent described in movement component</summary>
        public unsafe NavigationData MyNavData {
            get {return PathFollowingComponent_ptr->MyNavData;}
            set {PathFollowingComponent_ptr->MyNavData = value;}
        }
        static PathFollowingComponent() {
            StaticClass = Main.GetClass("PathFollowingComponent");
        }
        internal unsafe PathFollowingComponent_fields* PathFollowingComponent_ptr => (PathFollowingComponent_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator PathFollowingComponent(IntPtr p) => UObject.Make<PathFollowingComponent>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static PathFollowingComponent DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static PathFollowingComponent New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
