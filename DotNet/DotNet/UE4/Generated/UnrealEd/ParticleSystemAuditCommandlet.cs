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
using UE4.UnrealEd.Native;
using UE4.Engine;

namespace UE4.UnrealEd {
    ///<summary>Particle System Audit Commandlet</summary>
    public unsafe partial class ParticleSystemAuditCommandlet : Commandlet  {
        ///<summary>If a particle system has a spawn rate or burst count greater than this value, it will be reported</summary>
        public unsafe float HighSpawnRateOrBurstThreshold {
            get {return ParticleSystemAuditCommandlet_ptr->HighSpawnRateOrBurstThreshold;}
            set {ParticleSystemAuditCommandlet_ptr->HighSpawnRateOrBurstThreshold = value;}
        }
        ///<summary>If a particle system has an LODDistance larger than this value, it will be reported</summary>
        public unsafe float FarLODDistanceTheshold {
            get {return ParticleSystemAuditCommandlet_ptr->FarLODDistanceTheshold;}
            set {ParticleSystemAuditCommandlet_ptr->FarLODDistanceTheshold = value;}
        }
        static ParticleSystemAuditCommandlet() {
            StaticClass = Main.GetClass("ParticleSystemAuditCommandlet");
        }
        internal unsafe ParticleSystemAuditCommandlet_fields* ParticleSystemAuditCommandlet_ptr => (ParticleSystemAuditCommandlet_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator ParticleSystemAuditCommandlet(IntPtr p) => UObject.Make<ParticleSystemAuditCommandlet>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static ParticleSystemAuditCommandlet DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static ParticleSystemAuditCommandlet New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
