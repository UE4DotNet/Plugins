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
    ///<summary>Particle Module Vector Field Global</summary>
    public unsafe partial class ParticleModuleVectorFieldGlobal : ParticleModuleVectorFieldBase  {
        public bool bOverrideGlobalVectorFieldTightness {
            get {return Main.GetGetBoolPropertyByName(this, "bOverrideGlobalVectorFieldTightness"); }
            set {Main.SetGetBoolPropertyByName(this, "bOverrideGlobalVectorFieldTightness", value); }
        }
        ///<summary>Global vector field scale.</summary>
        public unsafe float GlobalVectorFieldScale {
            get {return ParticleModuleVectorFieldGlobal_ptr->GlobalVectorFieldScale;}
            set {ParticleModuleVectorFieldGlobal_ptr->GlobalVectorFieldScale = value;}
        }
        ///<summary>Global vector field tightness override.</summary>
        public unsafe float GlobalVectorFieldTightness {
            get {return ParticleModuleVectorFieldGlobal_ptr->GlobalVectorFieldTightness;}
            set {ParticleModuleVectorFieldGlobal_ptr->GlobalVectorFieldTightness = value;}
        }
        static ParticleModuleVectorFieldGlobal() {
            StaticClass = Main.GetClass("ParticleModuleVectorFieldGlobal");
        }
        internal unsafe ParticleModuleVectorFieldGlobal_fields* ParticleModuleVectorFieldGlobal_ptr => (ParticleModuleVectorFieldGlobal_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator ParticleModuleVectorFieldGlobal(IntPtr p) => UObject.Make<ParticleModuleVectorFieldGlobal>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static ParticleModuleVectorFieldGlobal DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static ParticleModuleVectorFieldGlobal New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
