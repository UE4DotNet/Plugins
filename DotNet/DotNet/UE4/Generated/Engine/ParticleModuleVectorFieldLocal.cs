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
    ///<summary>Particle Module Vector Field Local</summary>
    public unsafe partial class ParticleModuleVectorFieldLocal : ParticleModuleVectorFieldBase  {
        ///<summary>Vector field asset to use.</summary>
        public unsafe VectorField VectorField {
            get {return ParticleModuleVectorFieldLocal_ptr->VectorField;}
            set {ParticleModuleVectorFieldLocal_ptr->VectorField = value;}
        }
        ///<summary>Translation of the vector field relative to the emitter.</summary>
        public unsafe Vector RelativeTranslation {
            get {return ParticleModuleVectorFieldLocal_ptr->RelativeTranslation;}
            set {ParticleModuleVectorFieldLocal_ptr->RelativeTranslation = value;}
        }
        ///<summary>Rotation of the vector field relative to the emitter.</summary>
        public unsafe Rotator RelativeRotation {
            get {return ParticleModuleVectorFieldLocal_ptr->RelativeRotation;}
            set {ParticleModuleVectorFieldLocal_ptr->RelativeRotation = value;}
        }
        ///<summary>Scale of the vector field relative to the emitter.</summary>
        public unsafe Vector RelativeScale3D {
            get {return ParticleModuleVectorFieldLocal_ptr->RelativeScale3D;}
            set {ParticleModuleVectorFieldLocal_ptr->RelativeScale3D = value;}
        }
        ///<summary>Intensity of the local vector field.</summary>
        public unsafe float Intensity {
            get {return ParticleModuleVectorFieldLocal_ptr->Intensity;}
            set {ParticleModuleVectorFieldLocal_ptr->Intensity = value;}
        }
        ///<summary>Tightness tweak value: 0: Force 1: Velocity.</summary>
        public unsafe float Tightness {
            get {return ParticleModuleVectorFieldLocal_ptr->Tightness;}
            set {ParticleModuleVectorFieldLocal_ptr->Tightness = value;}
        }
        public bool bIgnoreComponentTransform {
            get {return Main.GetGetBoolPropertyByName(this, "bIgnoreComponentTransform"); }
            set {Main.SetGetBoolPropertyByName(this, "bIgnoreComponentTransform", value); }
        }
        public bool bTileX {
            get {return Main.GetGetBoolPropertyByName(this, "bTileX"); }
            set {Main.SetGetBoolPropertyByName(this, "bTileX", value); }
        }
        public bool bTileY {
            get {return Main.GetGetBoolPropertyByName(this, "bTileY"); }
            set {Main.SetGetBoolPropertyByName(this, "bTileY", value); }
        }
        public bool bTileZ {
            get {return Main.GetGetBoolPropertyByName(this, "bTileZ"); }
            set {Main.SetGetBoolPropertyByName(this, "bTileZ", value); }
        }
        public bool bUseFixDT {
            get {return Main.GetGetBoolPropertyByName(this, "bUseFixDT"); }
            set {Main.SetGetBoolPropertyByName(this, "bUseFixDT", value); }
        }
        static ParticleModuleVectorFieldLocal() {
            StaticClass = Main.GetClass("ParticleModuleVectorFieldLocal");
        }
        internal unsafe ParticleModuleVectorFieldLocal_fields* ParticleModuleVectorFieldLocal_ptr => (ParticleModuleVectorFieldLocal_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator ParticleModuleVectorFieldLocal(IntPtr p) => UObject.Make<ParticleModuleVectorFieldLocal>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static ParticleModuleVectorFieldLocal DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static ParticleModuleVectorFieldLocal New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
