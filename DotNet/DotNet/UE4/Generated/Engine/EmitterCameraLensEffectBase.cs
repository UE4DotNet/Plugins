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
    ///<summary>Emitter Camera Lens Effect Base</summary>
    public unsafe partial class EmitterCameraLensEffectBase : Emitter  {
        ///<summary>Particle System to use</summary>
        public unsafe ParticleSystem PS_CameraEffect {
            get {return EmitterCameraLensEffectBase_ptr->PS_CameraEffect;}
            set {EmitterCameraLensEffectBase_ptr->PS_CameraEffect = value;}
        }
        ///<summary>Camera this emitter is attached to, will be notified when emitter is destroyed</summary>
        public unsafe PlayerCameraManager BaseCamera {
            get {return EmitterCameraLensEffectBase_ptr->BaseCamera;}
            set {EmitterCameraLensEffectBase_ptr->BaseCamera = value;}
        }
        ///<summary>Effect-to-camera transform to allow arbitrary placement of the particle system .</summary>
        ///<remarks>Note the X component of the location will be scaled with camera fov to keep the lens effect the same apparent size.</remarks>
        public unsafe Transform RelativeTransform {
            get {return EmitterCameraLensEffectBase_ptr->RelativeTransform;}
            set {EmitterCameraLensEffectBase_ptr->RelativeTransform = value;}
        }
        ///<summary>This is the assumed FOV for which the effect was authored. The code will make automatic adjustments to make it look the same at different FOVs</summary>
        public unsafe float BaseFOV {
            get {return EmitterCameraLensEffectBase_ptr->BaseFOV;}
            set {EmitterCameraLensEffectBase_ptr->BaseFOV = value;}
        }
        public bool bAllowMultipleInstances {
            get {return Main.GetGetBoolPropertyByName(this, "bAllowMultipleInstances"); }
            set {Main.SetGetBoolPropertyByName(this, "bAllowMultipleInstances", value); }
        }
        public bool bResetWhenRetriggered {
            get {return Main.GetGetBoolPropertyByName(this, "bResetWhenRetriggered"); }
            set {Main.SetGetBoolPropertyByName(this, "bResetWhenRetriggered", value); }
        }
        ///<summary>If an emitter class in this array is currently playing, do not play this effect.</summary>
        ///<remarks>Useful for preventing multiple similar or expensive camera effects from playing simultaneously.</remarks>
        public ObjectArrayField<Class> EmittersToTreatAsSame{ get {
            if(EmittersToTreatAsSame_store == null) EmittersToTreatAsSame_store = new ObjectArrayField<Class> (&EmitterCameraLensEffectBase_ptr->EmittersToTreatAsSame);
            return EmittersToTreatAsSame_store;
        } }
        private ObjectArrayField<Class> EmittersToTreatAsSame_store;

        static EmitterCameraLensEffectBase() {
            StaticClass = Main.GetClass("EmitterCameraLensEffectBase");
        }
        internal unsafe EmitterCameraLensEffectBase_fields* EmitterCameraLensEffectBase_ptr => (EmitterCameraLensEffectBase_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator EmitterCameraLensEffectBase(IntPtr p) => UObject.Make<EmitterCameraLensEffectBase>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static EmitterCameraLensEffectBase DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static EmitterCameraLensEffectBase New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
