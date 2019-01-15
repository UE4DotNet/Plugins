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
    ///<summary>ShapeComponent is a PrimitiveComponent that is represented by a simple geometrical shape (sphere, capsule, box, etc).</summary>
    public unsafe partial class ShapeComponent : PrimitiveComponent  {
        ///<summary>Color used to draw the shape.</summary>
        public unsafe Color ShapeColor {
            get {return ShapeComponent_ptr->ShapeColor;}
        }
        ///<summary>Description of collision</summary>
        public unsafe BodySetup ShapeBodySetup {
            get {return ShapeComponent_ptr->ShapeBodySetup;}
            set {ShapeComponent_ptr->ShapeBodySetup = value;}
        }
        public bool bDrawOnlyIfSelected {
            get {return Main.GetGetBoolPropertyByName(this, "bDrawOnlyIfSelected"); }
            set {Main.SetGetBoolPropertyByName(this, "bDrawOnlyIfSelected", value); }
        }
        public bool bShouldCollideWhenPlacing {
            get {return Main.GetGetBoolPropertyByName(this, "bShouldCollideWhenPlacing"); }
            set {Main.SetGetBoolPropertyByName(this, "bShouldCollideWhenPlacing", value); }
        }
        public bool bDynamicObstacle {
            get {return Main.GetGetBoolPropertyByName(this, "bDynamicObstacle"); }
            set {Main.SetGetBoolPropertyByName(this, "bDynamicObstacle", value); }
        }
        ///<summary>Navigation area type (empty = default obstacle)</summary>
        public unsafe SubclassOf<NavAreaBase> AreaClass {
            get {return ShapeComponent_ptr->AreaClass;}
            set {ShapeComponent_ptr->AreaClass = value;}
        }
        static ShapeComponent() {
            StaticClass = Main.GetClass("ShapeComponent");
        }
        internal unsafe ShapeComponent_fields* ShapeComponent_ptr => (ShapeComponent_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator ShapeComponent(IntPtr p) => UObject.Make<ShapeComponent>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static ShapeComponent DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static ShapeComponent New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
