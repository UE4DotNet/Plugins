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
    ///<summary>Particle Module Event Receiver Spawn</summary>
    public unsafe partial class ParticleModuleEventReceiverSpawn : ParticleModuleEventReceiverBase  {
        ///<summary>The number of particles to spawn.</summary>
        public unsafe RawDistributionFloat SpawnCount {
            get {return ParticleModuleEventReceiverSpawn_ptr->SpawnCount;}
            set {ParticleModuleEventReceiverSpawn_ptr->SpawnCount = value;}
        }
        public bool bUseParticleTime {
            get {return Main.GetGetBoolPropertyByName(this, "bUseParticleTime"); }
            set {Main.SetGetBoolPropertyByName(this, "bUseParticleTime", value); }
        }
        public bool bUsePSysLocation {
            get {return Main.GetGetBoolPropertyByName(this, "bUsePSysLocation"); }
            set {Main.SetGetBoolPropertyByName(this, "bUsePSysLocation", value); }
        }
        public bool bInheritVelocity {
            get {return Main.GetGetBoolPropertyByName(this, "bInheritVelocity"); }
            set {Main.SetGetBoolPropertyByName(this, "bInheritVelocity", value); }
        }
        ///<summary>If bInheritVelocity is true, scale the velocity with this.</summary>
        public unsafe RawDistributionVector InheritVelocityScale {
            get {return ParticleModuleEventReceiverSpawn_ptr->InheritVelocityScale;}
            set {ParticleModuleEventReceiverSpawn_ptr->InheritVelocityScale = value;}
        }
        ///<summary>Array of physical materials that can be used to allow or ban a specific set of materials when receiving collision events.</summary>
        public ObjectArrayField<PhysicalMaterial> PhysicalMaterials{ get {
            if(PhysicalMaterials_store == null) PhysicalMaterials_store = new ObjectArrayField<PhysicalMaterial> (&ParticleModuleEventReceiverSpawn_ptr->PhysicalMaterials);
            return PhysicalMaterials_store;
        } }
        private ObjectArrayField<PhysicalMaterial> PhysicalMaterials_store;

        public bool bBanPhysicalMaterials {
            get {return Main.GetGetBoolPropertyByName(this, "bBanPhysicalMaterials"); }
            set {Main.SetGetBoolPropertyByName(this, "bBanPhysicalMaterials", value); }
        }
        static ParticleModuleEventReceiverSpawn() {
            StaticClass = Main.GetClass("ParticleModuleEventReceiverSpawn");
        }
        internal unsafe ParticleModuleEventReceiverSpawn_fields* ParticleModuleEventReceiverSpawn_ptr => (ParticleModuleEventReceiverSpawn_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator ParticleModuleEventReceiverSpawn(IntPtr p) => UObject.Make<ParticleModuleEventReceiverSpawn>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static ParticleModuleEventReceiverSpawn DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static ParticleModuleEventReceiverSpawn New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
