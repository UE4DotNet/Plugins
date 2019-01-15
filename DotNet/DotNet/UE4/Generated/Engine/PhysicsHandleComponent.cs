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
    ///<summary>Utility object for moving physics objects around.</summary>
    public unsafe partial class PhysicsHandleComponent : ActorComponent  {

        ///<summary>Returns the currently grabbed component, or null if nothing is grabbed.</summary>
        public PrimitiveComponent GetGrabbedComponent()  => 
            PhysicsHandleComponent_methods.GetGrabbedComponent_method.Invoke(ObjPointer);

        ///<summary>Get the current location and rotation</summary>
        public (Vector, Rotator) GetTargetLocationAndRotation()  => 
            PhysicsHandleComponent_methods.GetTargetLocationAndRotation_method.Invoke(ObjPointer);

        ///<summary>Grab Component</summary>
        public void GrabComponent(PrimitiveComponent Component, Name InBoneName, Vector GrabLocation, bool bConstrainRotation)  => 
            PhysicsHandleComponent_methods.GrabComponent_method.Invoke(ObjPointer, Component, InBoneName, GrabLocation, bConstrainRotation);

        ///<summary>Grab the specified component at a given location. Does NOT constraint rotation which means the handle will pivot about GrabLocation.</summary>
        public void GrabComponentAtLocation(PrimitiveComponent Component, Name InBoneName, Vector GrabLocation)  => 
            PhysicsHandleComponent_methods.GrabComponentAtLocation_method.Invoke(ObjPointer, Component, InBoneName, GrabLocation);

        ///<summary>Grab the specified component at a given location and rotation. Constrains rotation.</summary>
        public void GrabComponentAtLocationWithRotation(PrimitiveComponent Component, Name InBoneName, Vector Location, Rotator Rotation)  => 
            PhysicsHandleComponent_methods.GrabComponentAtLocationWithRotation_method.Invoke(ObjPointer, Component, InBoneName, Location, Rotation);

        ///<summary>Release the currently held component</summary>
        public void ReleaseComponent()  => 
            PhysicsHandleComponent_methods.ReleaseComponent_method.Invoke(ObjPointer);

        ///<summary>Set angular damping</summary>
        public void SetAngularDamping(float NewAngularDamping)  => 
            PhysicsHandleComponent_methods.SetAngularDamping_method.Invoke(ObjPointer, NewAngularDamping);

        ///<summary>Set angular stiffness</summary>
        public void SetAngularStiffness(float NewAngularStiffness)  => 
            PhysicsHandleComponent_methods.SetAngularStiffness_method.Invoke(ObjPointer, NewAngularStiffness);

        ///<summary>Set interpolation speed</summary>
        public void SetInterpolationSpeed(float NewInterpolationSpeed)  => 
            PhysicsHandleComponent_methods.SetInterpolationSpeed_method.Invoke(ObjPointer, NewInterpolationSpeed);

        ///<summary>Set linear damping</summary>
        public void SetLinearDamping(float NewLinearDamping)  => 
            PhysicsHandleComponent_methods.SetLinearDamping_method.Invoke(ObjPointer, NewLinearDamping);

        ///<summary>Set linear stiffness</summary>
        public void SetLinearStiffness(float NewLinearStiffness)  => 
            PhysicsHandleComponent_methods.SetLinearStiffness_method.Invoke(ObjPointer, NewLinearStiffness);

        ///<summary>Set the target location</summary>
        public void SetTargetLocation(Vector NewLocation)  => 
            PhysicsHandleComponent_methods.SetTargetLocation_method.Invoke(ObjPointer, NewLocation);

        ///<summary>Set target location and rotation</summary>
        public void SetTargetLocationAndRotation(Vector NewLocation, Rotator NewRotation)  => 
            PhysicsHandleComponent_methods.SetTargetLocationAndRotation_method.Invoke(ObjPointer, NewLocation, NewRotation);

        ///<summary>Set the target rotation</summary>
        public void SetTargetRotation(Rotator NewRotation)  => 
            PhysicsHandleComponent_methods.SetTargetRotation_method.Invoke(ObjPointer, NewRotation);
        ///<summary>Component we are currently holding</summary>
        public unsafe PrimitiveComponent GrabbedComponent {
            get {return PhysicsHandleComponent_ptr->GrabbedComponent;}
            set {PhysicsHandleComponent_ptr->GrabbedComponent = value;}
        }
        public bool bSoftAngularConstraint {
            get {return Main.GetGetBoolPropertyByName(this, "bSoftAngularConstraint"); }
        }
        public bool bSoftLinearConstraint {
            get {return Main.GetGetBoolPropertyByName(this, "bSoftLinearConstraint"); }
        }
        public bool bInterpolateTarget {
            get {return Main.GetGetBoolPropertyByName(this, "bInterpolateTarget"); }
            set {Main.SetGetBoolPropertyByName(this, "bInterpolateTarget", value); }
        }
        ///<summary>Linear damping of the handle spring.</summary>
        public unsafe float LinearDamping {
            get {return PhysicsHandleComponent_ptr->LinearDamping;}
        }
        ///<summary>Linear stiffness of the handle spring</summary>
        public unsafe float LinearStiffness {
            get {return PhysicsHandleComponent_ptr->LinearStiffness;}
        }
        ///<summary>Angular damping of the handle spring</summary>
        public unsafe float AngularDamping {
            get {return PhysicsHandleComponent_ptr->AngularDamping;}
        }
        ///<summary>Angular stiffness of the handle spring</summary>
        public unsafe float AngularStiffness {
            get {return PhysicsHandleComponent_ptr->AngularStiffness;}
        }
        ///<summary>How quickly we interpolate the physics target transform</summary>
        public unsafe float InterpolationSpeed {
            get {return PhysicsHandleComponent_ptr->InterpolationSpeed;}
        }
        static PhysicsHandleComponent() {
            StaticClass = Main.GetClass("PhysicsHandleComponent");
        }
        internal unsafe PhysicsHandleComponent_fields* PhysicsHandleComponent_ptr => (PhysicsHandleComponent_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator PhysicsHandleComponent(IntPtr p) => UObject.Make<PhysicsHandleComponent>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static PhysicsHandleComponent DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static PhysicsHandleComponent New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
