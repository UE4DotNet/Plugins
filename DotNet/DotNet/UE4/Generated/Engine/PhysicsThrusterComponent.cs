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
    ///<summary>
    ///Used with objects that have physics to apply a force down the negative-X direction
    ///ie.
    ///</summary>
    ///<remarks>point X in the direction you want the thrust in.</remarks>
    public unsafe partial class PhysicsThrusterComponent : SceneComponent  {
        ///<summary>Strength of thrust force applied to the base object.</summary>
        public unsafe float ThrustStrength {
            get {return PhysicsThrusterComponent_ptr->ThrustStrength;}
            set {PhysicsThrusterComponent_ptr->ThrustStrength = value;}
        }
        static PhysicsThrusterComponent() {
            StaticClass = Main.GetClass("PhysicsThrusterComponent");
        }
        internal unsafe PhysicsThrusterComponent_fields* PhysicsThrusterComponent_ptr => (PhysicsThrusterComponent_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator PhysicsThrusterComponent(IntPtr p) => UObject.Make<PhysicsThrusterComponent>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static PhysicsThrusterComponent DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static PhysicsThrusterComponent New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
