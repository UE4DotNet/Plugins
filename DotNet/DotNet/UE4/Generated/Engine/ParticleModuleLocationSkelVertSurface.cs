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
    ///<summary>Particle Module Location Skel Vert Surface</summary>
    public unsafe partial class ParticleModuleLocationSkelVertSurface : ParticleModuleLocationBase  {
        ///<summary>Whether the module uses Verts or Surfaces for locations.</summary>
        ///<remarks>
        ///VERTSURFACESOURCE_Vert          - Use Verts as the source locations.
        ///VERTSURFACESOURCE_Surface       - Use Surfaces as the source locations.
        ///</remarks>
        public unsafe byte SourceType {
            get {return ParticleModuleLocationSkelVertSurface_ptr->SourceType;}
            set {ParticleModuleLocationSkelVertSurface_ptr->SourceType = value;}
        }
        ///<summary>An offset to apply to each vert/surface</summary>
        public unsafe Vector UniversalOffset {
            get {return ParticleModuleLocationSkelVertSurface_ptr->UniversalOffset;}
            set {ParticleModuleLocationSkelVertSurface_ptr->UniversalOffset = value;}
        }
        public bool bUpdatePositionEachFrame {
            get {return Main.GetGetBoolPropertyByName(this, "bUpdatePositionEachFrame"); }
            set {Main.SetGetBoolPropertyByName(this, "bUpdatePositionEachFrame", value); }
        }
        public bool bOrientMeshEmitters {
            get {return Main.GetGetBoolPropertyByName(this, "bOrientMeshEmitters"); }
            set {Main.SetGetBoolPropertyByName(this, "bOrientMeshEmitters", value); }
        }
        public bool bInheritBoneVelocity {
            get {return Main.GetGetBoolPropertyByName(this, "bInheritBoneVelocity"); }
            set {Main.SetGetBoolPropertyByName(this, "bInheritBoneVelocity", value); }
        }
        ///<summary>A scale on how much of the bone's velocity a particle will inherit.</summary>
        public unsafe float InheritVelocityScale {
            get {return ParticleModuleLocationSkelVertSurface_ptr->InheritVelocityScale;}
            set {ParticleModuleLocationSkelVertSurface_ptr->InheritVelocityScale = value;}
        }
        ///<summary>The parameter name of the skeletal mesh actor that supplies the SkelMeshComponent for in-game.</summary>
        public unsafe Name SkelMeshActorParamName {
            get {return ParticleModuleLocationSkelVertSurface_ptr->SkelMeshActorParamName;}
            set {ParticleModuleLocationSkelVertSurface_ptr->SkelMeshActorParamName = value;}
        }
        ///<summary>The name of the skeletal mesh to use in the editor</summary>
        public unsafe SkeletalMesh EditorSkelMesh {
            get {return ParticleModuleLocationSkelVertSurface_ptr->EditorSkelMesh;}
            set {ParticleModuleLocationSkelVertSurface_ptr->EditorSkelMesh = value;}
        }
         //TODO: array not UObject TArray ValidAssociatedBones
        public bool bEnforceNormalCheck {
            get {return Main.GetGetBoolPropertyByName(this, "bEnforceNormalCheck"); }
            set {Main.SetGetBoolPropertyByName(this, "bEnforceNormalCheck", value); }
        }
        ///<summary>Use this normal to restrict spawning locations</summary>
        public unsafe Vector NormalToCompare {
            get {return ParticleModuleLocationSkelVertSurface_ptr->NormalToCompare;}
            set {ParticleModuleLocationSkelVertSurface_ptr->NormalToCompare = value;}
        }
        ///<summary>Normal tolerance.  0 degrees means it must be an exact match, 180 degrees means it can be any angle.</summary>
        public unsafe float NormalCheckToleranceDegrees {
            get {return ParticleModuleLocationSkelVertSurface_ptr->NormalCheckToleranceDegrees;}
            set {ParticleModuleLocationSkelVertSurface_ptr->NormalCheckToleranceDegrees = value;}
        }
        ///<summary>Normal tolerance.</summary>
        ///<remarks>
        ///Value between 1.0 and -1.0 with 1.0 being exact match, 0.0 being everything up to
        ///              perpendicular and -1.0 being any direction or don't restrict at all.
        ///</remarks>
        public unsafe float NormalCheckTolerance {
            get {return ParticleModuleLocationSkelVertSurface_ptr->NormalCheckTolerance;}
            set {ParticleModuleLocationSkelVertSurface_ptr->NormalCheckTolerance = value;}
        }
         //TODO: array not UObject TArray ValidMaterialIndices
        public bool bInheritVertexColor {
            get {return Main.GetGetBoolPropertyByName(this, "bInheritVertexColor"); }
            set {Main.SetGetBoolPropertyByName(this, "bInheritVertexColor", value); }
        }
        public bool bInheritUV {
            get {return Main.GetGetBoolPropertyByName(this, "bInheritUV"); }
            set {Main.SetGetBoolPropertyByName(this, "bInheritUV", value); }
        }
         //TODO: numeric uint32 InheritUVChannel
        static ParticleModuleLocationSkelVertSurface() {
            StaticClass = Main.GetClass("ParticleModuleLocationSkelVertSurface");
        }
        internal unsafe ParticleModuleLocationSkelVertSurface_fields* ParticleModuleLocationSkelVertSurface_ptr => (ParticleModuleLocationSkelVertSurface_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator ParticleModuleLocationSkelVertSurface(IntPtr p) => UObject.Make<ParticleModuleLocationSkelVertSurface>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static ParticleModuleLocationSkelVertSurface DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static ParticleModuleLocationSkelVertSurface New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
