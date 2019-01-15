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
using UE4.Foliage.Native;
using UE4.Engine;

namespace UE4.Foliage {
    ///<summary>Interactive Foliage Actor</summary>
    public unsafe partial class InteractiveFoliageActor : StaticMeshActor  {
        ///<summary>Collision cylinder</summary>
        public unsafe CapsuleComponent CapsuleComponent {
            get {return InteractiveFoliageActor_ptr->CapsuleComponent;}
            set {InteractiveFoliageActor_ptr->CapsuleComponent = value;}
        }
        ///<summary>Position of the last actor to enter the collision cylinder.</summary>
        ///<remarks>This currently does not handle multiple actors affecting the foliage simultaneously.</remarks>
        public unsafe Vector TouchingActorEntryPosition {
            get {return InteractiveFoliageActor_ptr->TouchingActorEntryPosition;}
            set {InteractiveFoliageActor_ptr->TouchingActorEntryPosition = value;}
        }
        ///<summary>Simulated physics state</summary>
        public unsafe Vector FoliageVelocity {
            get {return InteractiveFoliageActor_ptr->FoliageVelocity;}
            set {InteractiveFoliageActor_ptr->FoliageVelocity = value;}
        }
        ///<summary>@todo document</summary>
        public unsafe Vector FoliageForce {
            get {return InteractiveFoliageActor_ptr->FoliageForce;}
            set {InteractiveFoliageActor_ptr->FoliageForce = value;}
        }
        ///<summary>@todo document</summary>
        public unsafe Vector FoliagePosition {
            get {return InteractiveFoliageActor_ptr->FoliagePosition;}
            set {InteractiveFoliageActor_ptr->FoliagePosition = value;}
        }
        ///<summary>Scales forces applied from damage events.</summary>
        public unsafe float FoliageDamageImpulseScale {
            get {return InteractiveFoliageActor_ptr->FoliageDamageImpulseScale;}
            set {InteractiveFoliageActor_ptr->FoliageDamageImpulseScale = value;}
        }
        ///<summary>Scales forces applied from touch events.</summary>
        public unsafe float FoliageTouchImpulseScale {
            get {return InteractiveFoliageActor_ptr->FoliageTouchImpulseScale;}
            set {InteractiveFoliageActor_ptr->FoliageTouchImpulseScale = value;}
        }
        ///<summary>Determines how strong the force that pushes toward the spring's center will be.</summary>
        public unsafe float FoliageStiffness {
            get {return InteractiveFoliageActor_ptr->FoliageStiffness;}
            set {InteractiveFoliageActor_ptr->FoliageStiffness = value;}
        }
        ///<summary>Same as FoliageStiffness, but the strength of this force increases with the square of the distance to the spring's center.</summary>
        ///<remarks>This force is used to prevent the spring from extending past a certain point due to touch and damage forces.</remarks>
        public unsafe float FoliageStiffnessQuadratic {
            get {return InteractiveFoliageActor_ptr->FoliageStiffnessQuadratic;}
            set {InteractiveFoliageActor_ptr->FoliageStiffnessQuadratic = value;}
        }
        ///<summary>Determines the amount of energy lost by the spring as it oscillates.</summary>
        ///<remarks>This force is similar to air friction.</remarks>
        public unsafe float FoliageDamping {
            get {return InteractiveFoliageActor_ptr->FoliageDamping;}
            set {InteractiveFoliageActor_ptr->FoliageDamping = value;}
        }
        ///<summary>Clamps the magnitude of each damage force applied.</summary>
        public unsafe float MaxDamageImpulse {
            get {return InteractiveFoliageActor_ptr->MaxDamageImpulse;}
            set {InteractiveFoliageActor_ptr->MaxDamageImpulse = value;}
        }
        ///<summary>Clamps the magnitude of each touch force applied.</summary>
        public unsafe float MaxTouchImpulse {
            get {return InteractiveFoliageActor_ptr->MaxTouchImpulse;}
            set {InteractiveFoliageActor_ptr->MaxTouchImpulse = value;}
        }
        ///<summary>Clamps the magnitude of combined forces applied each update.</summary>
        public unsafe float MaxForce {
            get {return InteractiveFoliageActor_ptr->MaxForce;}
            set {InteractiveFoliageActor_ptr->MaxForce = value;}
        }
        ///<summary>@todo - hook this up     @todo document</summary>
        public unsafe float Mass {
            get {return InteractiveFoliageActor_ptr->Mass;}
            set {InteractiveFoliageActor_ptr->Mass = value;}
        }
        static InteractiveFoliageActor() {
            StaticClass = Main.GetClass("InteractiveFoliageActor");
        }
        internal unsafe InteractiveFoliageActor_fields* InteractiveFoliageActor_ptr => (InteractiveFoliageActor_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator InteractiveFoliageActor(IntPtr p) => UObject.Make<InteractiveFoliageActor>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static InteractiveFoliageActor DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static InteractiveFoliageActor New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
