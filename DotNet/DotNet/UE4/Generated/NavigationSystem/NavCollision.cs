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
using UE4.NavigationSystem.Native;
using UE4.Engine;

namespace UE4.NavigationSystem {
    ///<summary>Nav Collision</summary>
    public unsafe partial class NavCollision : NavCollisionBase  {
         //TODO: array not UObject TArray CylinderCollision
         //TODO: array not UObject TArray BoxCollision
        ///<summary>navigation area type (empty = default obstacle)</summary>
        public unsafe SubclassOf<NavArea> AreaClass {
            get {return NavCollision_ptr->AreaClass;}
            set {NavCollision_ptr->AreaClass = value;}
        }
        public bool bGatherConvexGeometry {
            get {return Main.GetGetBoolPropertyByName(this, "bGatherConvexGeometry"); }
            set {Main.SetGetBoolPropertyByName(this, "bGatherConvexGeometry", value); }
        }
        static NavCollision() {
            StaticClass = Main.GetClass("NavCollision");
        }
        internal unsafe NavCollision_fields* NavCollision_ptr => (NavCollision_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator NavCollision(IntPtr p) => UObject.Make<NavCollision>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static NavCollision DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static NavCollision New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
