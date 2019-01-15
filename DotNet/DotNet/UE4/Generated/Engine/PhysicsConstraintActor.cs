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
    ///<summary>Physics Constraint Actor</summary>
    public unsafe partial class PhysicsConstraintActor : RigidBodyBase  {
        ///<summary>Constraint Comp</summary>
        public unsafe PhysicsConstraintComponent ConstraintComp {
            get {return PhysicsConstraintActor_ptr->ConstraintComp;}
        }
        static PhysicsConstraintActor() {
            StaticClass = Main.GetClass("PhysicsConstraintActor");
        }
        internal unsafe PhysicsConstraintActor_fields* PhysicsConstraintActor_ptr => (PhysicsConstraintActor_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator PhysicsConstraintActor(IntPtr p) => UObject.Make<PhysicsConstraintActor>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static PhysicsConstraintActor DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static PhysicsConstraintActor New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
