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
using UE4.CableComponent.Native;
using UE4.Engine;

namespace UE4.CableComponent {
    ///<summary>Component that allows you to specify custom triangle mesh geometry</summary>
    public unsafe partial class CableComponent : MeshComponent  {

        ///<summary>Gets the Actor that the cable is attached to *</summary>
        public Actor GetAttachedActor()  => 
            CableComponent_methods.GetAttachedActor_method.Invoke(ObjPointer);

        ///<summary>Gets the specific USceneComponent that the cable is attached to *</summary>
        public SceneComponent GetAttachedComponent()  => 
            CableComponent_methods.GetAttachedComponent_method.Invoke(ObjPointer);

        ///<summary>Get array of locations of particles (in world space) making up the cable simulation.</summary>
        public IReadOnlyCollection<Vector> GetCableParticleLocations()  => 
            CableComponent_methods.GetCableParticleLocations_method.Invoke(ObjPointer);

        ///<summary>Attaches the end of the cable to a specific Component within an Actor *</summary>
        public void SetAttachEndTo(Actor Actor, Name ComponentProperty, Name SocketName)  => 
            CableComponent_methods.SetAttachEndTo_method.Invoke(ObjPointer, Actor, ComponentProperty, SocketName);
        public bool bAttachStart {
            get {return Main.GetGetBoolPropertyByName(this, "bAttachStart"); }
            set {Main.SetGetBoolPropertyByName(this, "bAttachStart", value); }
        }
        public bool bAttachEnd {
            get {return Main.GetGetBoolPropertyByName(this, "bAttachEnd"); }
            set {Main.SetGetBoolPropertyByName(this, "bAttachEnd", value); }
        }
        ///<summary>Actor or Component that the defines the end position of the cable</summary>
        public unsafe ComponentReference AttachEndTo {
            get {return CableComponent_ptr->AttachEndTo;}
            set {CableComponent_ptr->AttachEndTo = value;}
        }
        ///<summary>Socket name on the AttachEndTo component to attach to</summary>
        public unsafe Name AttachEndToSocketName {
            get {return CableComponent_ptr->AttachEndToSocketName;}
            set {CableComponent_ptr->AttachEndToSocketName = value;}
        }
        ///<summary>End location of cable, relative to AttachEndTo (or AttachEndToSocketName) if specified, otherwise relative to cable component.</summary>
        public unsafe Vector EndLocation {
            get {return CableComponent_ptr->EndLocation;}
            set {CableComponent_ptr->EndLocation = value;}
        }
        ///<summary>Rest length of the cable</summary>
        public unsafe float CableLength {
            get {return CableComponent_ptr->CableLength;}
            set {CableComponent_ptr->CableLength = value;}
        }
        ///<summary>How many segments the cable has</summary>
        public unsafe int NumSegments {
            get {return CableComponent_ptr->NumSegments;}
        }
        ///<summary>Controls the simulation substep time for the cable</summary>
        public unsafe float SubstepTime {
            get {return CableComponent_ptr->SubstepTime;}
        }
        ///<summary>The number of solver iterations controls how 'stiff' the cable is</summary>
        public unsafe int SolverIterations {
            get {return CableComponent_ptr->SolverIterations;}
            set {CableComponent_ptr->SolverIterations = value;}
        }
        public bool bEnableStiffness {
            get {return Main.GetGetBoolPropertyByName(this, "bEnableStiffness"); }
            set {Main.SetGetBoolPropertyByName(this, "bEnableStiffness", value); }
        }
        public bool bEnableCollision {
            get {return Main.GetGetBoolPropertyByName(this, "bEnableCollision"); }
            set {Main.SetGetBoolPropertyByName(this, "bEnableCollision", value); }
        }
        ///<summary>If collision is enabled, control how much sliding friction is applied when cable is in contact.</summary>
        public unsafe float CollisionFriction {
            get {return CableComponent_ptr->CollisionFriction;}
            set {CableComponent_ptr->CollisionFriction = value;}
        }
        ///<summary>Force vector (world space) applied to all particles in cable.</summary>
        public unsafe Vector CableForce {
            get {return CableComponent_ptr->CableForce;}
            set {CableComponent_ptr->CableForce = value;}
        }
        ///<summary>Scaling applied to world gravity affecting this cable.</summary>
        public unsafe float CableGravityScale {
            get {return CableComponent_ptr->CableGravityScale;}
            set {CableComponent_ptr->CableGravityScale = value;}
        }
        ///<summary>How wide the cable geometry is</summary>
        public unsafe float CableWidth {
            get {return CableComponent_ptr->CableWidth;}
            set {CableComponent_ptr->CableWidth = value;}
        }
        ///<summary>Number of sides of the cable geometry</summary>
        public unsafe int NumSides {
            get {return CableComponent_ptr->NumSides;}
        }
        ///<summary>How many times to repeat the material along the length of the cable</summary>
        public unsafe float TileMaterial {
            get {return CableComponent_ptr->TileMaterial;}
            set {CableComponent_ptr->TileMaterial = value;}
        }
        static CableComponent() {
            StaticClass = Main.GetClass("CableComponent");
        }
        internal unsafe CableComponent_fields* CableComponent_ptr => (CableComponent_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator CableComponent(IntPtr p) => UObject.Make<CableComponent>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static CableComponent DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static CableComponent New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
