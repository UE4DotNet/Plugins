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
    ///<summary>BodySetup contains all collision information that is associated with a single asset.</summary>
    ///<remarks>
    ///A single BodySetup instance is shared among many BodyInstances so that geometry data is not duplicated.
    ///Assets typically implement a GetBodySetup function that is used during physics state creation.
    ///
    ///@see GetBodySetup
    ///@see FBodyInstance
    ///</remarks>
    public unsafe partial class BodySetup : UObject  {
        ///<summary>Simplified collision representation of this</summary>
        public unsafe KAggregateGeom AggGeom {
            get {return BodySetup_ptr->AggGeom;}
            set {BodySetup_ptr->AggGeom = value;}
        }
        ///<summary>Used in the PhysicsAsset case. Associates this Body with Bone in a skeletal mesh.</summary>
        public unsafe Name BoneName {
            get {return BodySetup_ptr->BoneName;}
            set {BodySetup_ptr->BoneName = value;}
        }
        ///<summary>If simulated it will use physics, if kinematic it will not be affected by physics, but can interact with physically simulated bodies. Default will inherit from OwnerComponent's behavior.</summary>
        public unsafe byte PhysicsType {
            get {return BodySetup_ptr->PhysicsType;}
            set {BodySetup_ptr->PhysicsType = value;}
        }
        public bool bConsiderForBounds {
            get {return Main.GetGetBoolPropertyByName(this, "bConsiderForBounds"); }
            set {Main.SetGetBoolPropertyByName(this, "bConsiderForBounds", value); }
        }
        public bool bMeshCollideAll {
            get {return Main.GetGetBoolPropertyByName(this, "bMeshCollideAll"); }
            set {Main.SetGetBoolPropertyByName(this, "bMeshCollideAll", value); }
        }
        public bool bDoubleSidedGeometry {
            get {return Main.GetGetBoolPropertyByName(this, "bDoubleSidedGeometry"); }
            set {Main.SetGetBoolPropertyByName(this, "bDoubleSidedGeometry", value); }
        }
        public bool bGenerateNonMirroredCollision {
            get {return Main.GetGetBoolPropertyByName(this, "bGenerateNonMirroredCollision"); }
            set {Main.SetGetBoolPropertyByName(this, "bGenerateNonMirroredCollision", value); }
        }
        public bool bSharedCookedData {
            get {return Main.GetGetBoolPropertyByName(this, "bSharedCookedData"); }
            set {Main.SetGetBoolPropertyByName(this, "bSharedCookedData", value); }
        }
        public bool bGenerateMirroredCollision {
            get {return Main.GetGetBoolPropertyByName(this, "bGenerateMirroredCollision"); }
            set {Main.SetGetBoolPropertyByName(this, "bGenerateMirroredCollision", value); }
        }
        ///<summary>Collision Type for this body. This eventually changes response to collision to others *</summary>
        public unsafe byte CollisionReponse {
            get {return BodySetup_ptr->CollisionReponse;}
            set {BodySetup_ptr->CollisionReponse = value;}
        }
        ///<summary>Collision Trace behavior - by default, it will keep simple(convex)/complex(per-poly) separate *</summary>
        public unsafe byte CollisionTraceFlag {
            get {return BodySetup_ptr->CollisionTraceFlag;}
            set {BodySetup_ptr->CollisionTraceFlag = value;}
        }
        ///<summary>Physical material to use for simple collision on this body. Encodes information about density, friction etc.</summary>
        public unsafe PhysicalMaterial PhysMaterial {
            get {return BodySetup_ptr->PhysMaterial;}
            set {BodySetup_ptr->PhysMaterial = value;}
        }
        ///<summary>Custom walkable slope setting for this body.</summary>
        public unsafe WalkableSlopeOverride WalkableSlopeOverride {
            get {return BodySetup_ptr->WalkableSlopeOverride;}
            set {BodySetup_ptr->WalkableSlopeOverride = value;}
        }
        ///<summary>Default properties of the body instance, copied into objects on instantiation, was URB_BodyInstance</summary>
        public unsafe BodyInstance DefaultInstance {
            get {return BodySetup_ptr->DefaultInstance;}
            set {BodySetup_ptr->DefaultInstance = value;}
        }
        ///<summary>Build scale for this body setup (static mesh settings define this value)</summary>
        public unsafe Vector BuildScale3D {
            get {return BodySetup_ptr->BuildScale3D;}
            set {BodySetup_ptr->BuildScale3D = value;}
        }
        static BodySetup() {
            StaticClass = Main.GetClass("BodySetup");
        }
        internal unsafe BodySetup_fields* BodySetup_ptr => (BodySetup_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator BodySetup(IntPtr p) => UObject.Make<BodySetup>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static BodySetup DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static BodySetup New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
