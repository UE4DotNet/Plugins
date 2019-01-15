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
    ///<summary>Particle Module Trail Source</summary>
    public unsafe partial class ParticleModuleTrailSource : ParticleModuleTrailBase  {
        ///<summary>The source method for the trail.</summary>
        public unsafe byte SourceMethod {
            get {return ParticleModuleTrailSource_ptr->SourceMethod;}
            set {ParticleModuleTrailSource_ptr->SourceMethod = value;}
        }
        ///<summary>The name of the source - either the emitter or Actor.</summary>
        public unsafe Name SourceName {
            get {return ParticleModuleTrailSource_ptr->SourceName;}
            set {ParticleModuleTrailSource_ptr->SourceName = value;}
        }
        ///<summary>The strength of the tangent from the source point for each Trail.</summary>
        public unsafe RawDistributionFloat SourceStrength {
            get {return ParticleModuleTrailSource_ptr->SourceStrength;}
            set {ParticleModuleTrailSource_ptr->SourceStrength = value;}
        }
        public bool bLockSourceStength {
            get {return Main.GetGetBoolPropertyByName(this, "bLockSourceStength"); }
            set {Main.SetGetBoolPropertyByName(this, "bLockSourceStength", value); }
        }
        ///<summary>
        ///SourceOffsetCount
        ///The number of source offsets that can be expected to be found on the instance.
        ///</summary>
        ///<remarks>
        ///These must be named
        ///        TrailSourceOffset#
        ///</remarks>
        public unsafe int SourceOffsetCount {
            get {return ParticleModuleTrailSource_ptr->SourceOffsetCount;}
            set {ParticleModuleTrailSource_ptr->SourceOffsetCount = value;}
        }
         //TODO: array not UObject TArray SourceOffsetDefaults
        ///<summary>Particle selection method, when using the SourceMethod of Particle.</summary>
        public unsafe byte SelectionMethod {
            get {return ParticleModuleTrailSource_ptr->SelectionMethod;}
            set {ParticleModuleTrailSource_ptr->SelectionMethod = value;}
        }
        public bool bInheritRotation {
            get {return Main.GetGetBoolPropertyByName(this, "bInheritRotation"); }
            set {Main.SetGetBoolPropertyByName(this, "bInheritRotation", value); }
        }
        static ParticleModuleTrailSource() {
            StaticClass = Main.GetClass("ParticleModuleTrailSource");
        }
        internal unsafe ParticleModuleTrailSource_fields* ParticleModuleTrailSource_ptr => (ParticleModuleTrailSource_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator ParticleModuleTrailSource(IntPtr p) => UObject.Make<ParticleModuleTrailSource>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static ParticleModuleTrailSource DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static ParticleModuleTrailSource New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
