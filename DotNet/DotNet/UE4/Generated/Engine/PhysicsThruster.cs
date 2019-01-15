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
    ///Attach one of these on an object using physics simulation and it will apply a force down the negative-X direction
    ///ie.
    ///</summary>
    ///<remarks>point X in the direction you want the thrust in.</remarks>
    public unsafe partial class PhysicsThruster : RigidBodyBase  {
        ///<summary>Thruster component</summary>
        public unsafe PhysicsThrusterComponent ThrusterComponent {
            get {return PhysicsThruster_ptr->ThrusterComponent;}
        }
        ///<summary>Arrow Component</summary>
        public unsafe ArrowComponent ArrowComponent {
            get {return PhysicsThruster_ptr->ArrowComponent;}
            set {PhysicsThruster_ptr->ArrowComponent = value;}
        }
        static PhysicsThruster() {
            StaticClass = Main.GetClass("PhysicsThruster");
        }
        internal unsafe PhysicsThruster_fields* PhysicsThruster_ptr => (PhysicsThruster_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator PhysicsThruster(IntPtr p) => UObject.Make<PhysicsThruster>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static PhysicsThruster DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static PhysicsThruster New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
