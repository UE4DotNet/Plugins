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
    ///<summary>Physics Collision Handler</summary>
    public unsafe partial class PhysicsCollisionHandler : UObject  {
        ///<summary>How hard an impact must be to trigger effect/sound</summary>
        public unsafe float ImpactThreshold {
            get {return PhysicsCollisionHandler_ptr->ImpactThreshold;}
            set {PhysicsCollisionHandler_ptr->ImpactThreshold = value;}
        }
        ///<summary>Min time between effect/sound being triggered</summary>
        public unsafe float ImpactReFireDelay {
            get {return PhysicsCollisionHandler_ptr->ImpactReFireDelay;}
            set {PhysicsCollisionHandler_ptr->ImpactReFireDelay = value;}
        }
        ///<summary>Sound to play</summary>
        public unsafe SoundBase DefaultImpactSound {
            get {return PhysicsCollisionHandler_ptr->DefaultImpactSound;}
            set {PhysicsCollisionHandler_ptr->DefaultImpactSound = value;}
        }
        ///<summary>Time since last impact sound</summary>
        public unsafe float LastImpactSoundTime {
            get {return PhysicsCollisionHandler_ptr->LastImpactSoundTime;}
            set {PhysicsCollisionHandler_ptr->LastImpactSoundTime = value;}
        }
        static PhysicsCollisionHandler() {
            StaticClass = Main.GetClass("PhysicsCollisionHandler");
        }
        internal unsafe PhysicsCollisionHandler_fields* PhysicsCollisionHandler_ptr => (PhysicsCollisionHandler_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator PhysicsCollisionHandler(IntPtr p) => UObject.Make<PhysicsCollisionHandler>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static PhysicsCollisionHandler DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static PhysicsCollisionHandler New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
