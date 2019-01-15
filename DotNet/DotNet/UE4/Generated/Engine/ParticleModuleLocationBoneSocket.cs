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
    ///<summary>Particle Module Location Bone Socket</summary>
    public unsafe partial class ParticleModuleLocationBoneSocket : ParticleModuleLocationBase  {
        ///<summary>Whether the module uses Bones or Sockets for locations.</summary>
        ///<remarks>
        ///BONESOCKETSOURCE_Bones          - Use Bones as the source locations.
        ///BONESOCKETSOURCE_Sockets        - Use Sockets as the source locations.
        ///</remarks>
        public unsafe byte SourceType {
            get {return ParticleModuleLocationBoneSocket_ptr->SourceType;}
            set {ParticleModuleLocationBoneSocket_ptr->SourceType = value;}
        }
        ///<summary>An offset to apply to each bone/socket</summary>
        public unsafe Vector UniversalOffset {
            get {return ParticleModuleLocationBoneSocket_ptr->UniversalOffset;}
            set {ParticleModuleLocationBoneSocket_ptr->UniversalOffset = value;}
        }
         //TODO: array not UObject TArray SourceLocations
        ///<summary>The method by which to select the bone/socket to spawn at.</summary>
        ///<remarks>
        ///SEL_Sequential                  - loop through the bone/socket array in order
        ///SEL_Random                              - randomly select a bone/socket from the array
        ///</remarks>
        public unsafe byte SelectionMethod {
            get {return ParticleModuleLocationBoneSocket_ptr->SelectionMethod;}
            set {ParticleModuleLocationBoneSocket_ptr->SelectionMethod = value;}
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
            get {return ParticleModuleLocationBoneSocket_ptr->InheritVelocityScale;}
            set {ParticleModuleLocationBoneSocket_ptr->InheritVelocityScale = value;}
        }
        ///<summary>The parameter name of the skeletal mesh actor that supplies the SkelMeshComponent for in-game.</summary>
        public unsafe Name SkelMeshActorParamName {
            get {return ParticleModuleLocationBoneSocket_ptr->SkelMeshActorParamName;}
            set {ParticleModuleLocationBoneSocket_ptr->SkelMeshActorParamName = value;}
        }
        ///<summary>When we have no source locations and we need to track bone velocities due to bInheritBoneVelocity, we pre select a set of bones to use each frame.</summary>
        ///<remarks>
        ///This property determines how big the list is.
        ///Too low and the randomness of selection may suffer, too high and memory will be wasted.
        ///</remarks>
        public unsafe int NumPreSelectedIndices {
            get {return ParticleModuleLocationBoneSocket_ptr->NumPreSelectedIndices;}
            set {ParticleModuleLocationBoneSocket_ptr->NumPreSelectedIndices = value;}
        }
        ///<summary>The name of the skeletal mesh to use in the editor</summary>
        public unsafe SkeletalMesh EditorSkelMesh {
            get {return ParticleModuleLocationBoneSocket_ptr->EditorSkelMesh;}
            set {ParticleModuleLocationBoneSocket_ptr->EditorSkelMesh = value;}
        }
        static ParticleModuleLocationBoneSocket() {
            StaticClass = Main.GetClass("ParticleModuleLocationBoneSocket");
        }
        internal unsafe ParticleModuleLocationBoneSocket_fields* ParticleModuleLocationBoneSocket_ptr => (ParticleModuleLocationBoneSocket_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator ParticleModuleLocationBoneSocket(IntPtr p) => UObject.Make<ParticleModuleLocationBoneSocket>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static ParticleModuleLocationBoneSocket DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static ParticleModuleLocationBoneSocket New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
