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
    ///<summary>Particle Module Camera Offset</summary>
    public unsafe partial class ParticleModuleCameraOffset : ParticleModuleCameraBase  {
        ///<summary>The camera-relative offset to apply to sprite location</summary>
        public unsafe RawDistributionFloat CameraOffset {
            get {return ParticleModuleCameraOffset_ptr->CameraOffset;}
            set {ParticleModuleCameraOffset_ptr->CameraOffset = value;}
        }
        public bool bSpawnTimeOnly {
            get {return Main.GetGetBoolPropertyByName(this, "bSpawnTimeOnly"); }
            set {Main.SetGetBoolPropertyByName(this, "bSpawnTimeOnly", value); }
        }
        ///<summary>How to update the offset for this module.</summary>
        ///<remarks>
        ///DirectSet - Set the value directly (overwrite any previous setting)
        ///Additive  - Add the offset of this module to the existing offset
        ///Scalar    - Scale the existing offset by the value of this module
        ///</remarks>
        public unsafe byte UpdateMethod {
            get {return ParticleModuleCameraOffset_ptr->UpdateMethod;}
            set {ParticleModuleCameraOffset_ptr->UpdateMethod = value;}
        }
        static ParticleModuleCameraOffset() {
            StaticClass = Main.GetClass("ParticleModuleCameraOffset");
        }
        internal unsafe ParticleModuleCameraOffset_fields* ParticleModuleCameraOffset_ptr => (ParticleModuleCameraOffset_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator ParticleModuleCameraOffset(IntPtr p) => UObject.Make<ParticleModuleCameraOffset>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static ParticleModuleCameraOffset DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static ParticleModuleCameraOffset New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
