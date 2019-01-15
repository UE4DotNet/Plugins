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
    ///<summary>Particle Module Collision</summary>
    public unsafe partial class ParticleModuleCollision : ParticleModuleCollisionBase  {
        ///<summary>How much to `slow' the velocity of the particle after a collision.</summary>
        ///<remarks>Value is obtained using the EmitterTime at particle spawn.</remarks>
        public unsafe RawDistributionVector DampingFactor {
            get {return ParticleModuleCollision_ptr->DampingFactor;}
            set {ParticleModuleCollision_ptr->DampingFactor = value;}
        }
        ///<summary>How much to `slow' the rotation of the particle after a collision.</summary>
        ///<remarks>Value is obtained using the EmitterTime at particle spawn.</remarks>
        public unsafe RawDistributionVector DampingFactorRotation {
            get {return ParticleModuleCollision_ptr->DampingFactorRotation;}
            set {ParticleModuleCollision_ptr->DampingFactorRotation = value;}
        }
        ///<summary>The maximum number of collisions a particle can have.</summary>
        ///<remarks>Value is obtained using the EmitterTime at particle spawn.</remarks>
        public unsafe RawDistributionFloat MaxCollisions {
            get {return ParticleModuleCollision_ptr->MaxCollisions;}
            set {ParticleModuleCollision_ptr->MaxCollisions = value;}
        }
        ///<summary>What to do once a particles MaxCollisions is reached.</summary>
        ///<remarks>
        ///One of the following:
        ///EPCC_Kill
        ///        Kill the particle when MaxCollisions is reached
        ///EPCC_Freeze
        ///        Freeze in place, NO MORE UPDATES
        ///EPCC_HaltCollisions,
        ///        Stop collision checks, keep updating everything
        ///EPCC_FreezeTranslation,
        ///        Stop translations, keep updating everything else
        ///EPCC_FreezeRotation,
        ///        Stop rotations, keep updating everything else
        ///EPCC_FreezeMovement
        ///        Stop all movement, keep updating
        ///</remarks>
        public unsafe byte CollisionCompletionOption {
            get {return ParticleModuleCollision_ptr->CollisionCompletionOption;}
            set {ParticleModuleCollision_ptr->CollisionCompletionOption = value;}
        }
         //TODO: array not UObject TArray CollisionTypes
        public bool bApplyPhysics {
            get {return Main.GetGetBoolPropertyByName(this, "bApplyPhysics"); }
            set {Main.SetGetBoolPropertyByName(this, "bApplyPhysics", value); }
        }
        public bool bIgnoreTriggerVolumes {
            get {return Main.GetGetBoolPropertyByName(this, "bIgnoreTriggerVolumes"); }
            set {Main.SetGetBoolPropertyByName(this, "bIgnoreTriggerVolumes", value); }
        }
        ///<summary>The mass of the particle - for use when bApplyPhysics is true.</summary>
        ///<remarks>Value is obtained using the EmitterTime at particle spawn.</remarks>
        public unsafe RawDistributionFloat ParticleMass {
            get {return ParticleModuleCollision_ptr->ParticleMass;}
            set {ParticleModuleCollision_ptr->ParticleMass = value;}
        }
        ///<summary>
        ///The directional scalar value - used to scale the bounds to
        ///'assist' in avoiding inter-penetration or large gaps.
        ///</summary>
        public unsafe float DirScalar {
            get {return ParticleModuleCollision_ptr->DirScalar;}
            set {ParticleModuleCollision_ptr->DirScalar = value;}
        }
        public bool bPawnsDoNotDecrementCount {
            get {return Main.GetGetBoolPropertyByName(this, "bPawnsDoNotDecrementCount"); }
            set {Main.SetGetBoolPropertyByName(this, "bPawnsDoNotDecrementCount", value); }
        }
        public bool bOnlyVerticalNormalsDecrementCount {
            get {return Main.GetGetBoolPropertyByName(this, "bOnlyVerticalNormalsDecrementCount"); }
            set {Main.SetGetBoolPropertyByName(this, "bOnlyVerticalNormalsDecrementCount", value); }
        }
        ///<summary>The fudge factor to use to determine vertical.</summary>
        ///<remarks>
        ///True vertical will have a Hit.Normal.Z == 1.0
        ///This will allow for Z components in the range of
        ///[1.0-VerticalFudgeFactor..1.0]
        ///to count as vertical collisions.
        ///</remarks>
        public unsafe float VerticalFudgeFactor {
            get {return ParticleModuleCollision_ptr->VerticalFudgeFactor;}
            set {ParticleModuleCollision_ptr->VerticalFudgeFactor = value;}
        }
        ///<summary>How long to delay before checking a particle for collisions.</summary>
        ///<remarks>
        ///Value is retrieved using the EmitterTime.
        ///During update, the particle flag IgnoreCollisions will be
        ///set until the particle RelativeTime has surpassed the
        ///DelayAmount.
        ///</remarks>
        public unsafe RawDistributionFloat DelayAmount {
            get {return ParticleModuleCollision_ptr->DelayAmount;}
            set {ParticleModuleCollision_ptr->DelayAmount = value;}
        }
        public bool bDropDetail {
            get {return Main.GetGetBoolPropertyByName(this, "bDropDetail"); }
            set {Main.SetGetBoolPropertyByName(this, "bDropDetail", value); }
        }
        public bool bCollideOnlyIfVisible {
            get {return Main.GetGetBoolPropertyByName(this, "bCollideOnlyIfVisible"); }
            set {Main.SetGetBoolPropertyByName(this, "bCollideOnlyIfVisible", value); }
        }
        public bool bIgnoreSourceActor {
            get {return Main.GetGetBoolPropertyByName(this, "bIgnoreSourceActor"); }
            set {Main.SetGetBoolPropertyByName(this, "bIgnoreSourceActor", value); }
        }
        ///<summary>Max distance at which particle collision will occur.</summary>
        public unsafe float MaxCollisionDistance {
            get {return ParticleModuleCollision_ptr->MaxCollisionDistance;}
            set {ParticleModuleCollision_ptr->MaxCollisionDistance = value;}
        }
        static ParticleModuleCollision() {
            StaticClass = Main.GetClass("ParticleModuleCollision");
        }
        internal unsafe ParticleModuleCollision_fields* ParticleModuleCollision_ptr => (ParticleModuleCollision_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator ParticleModuleCollision(IntPtr p) => UObject.Make<ParticleModuleCollision>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static ParticleModuleCollision DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static ParticleModuleCollision New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
