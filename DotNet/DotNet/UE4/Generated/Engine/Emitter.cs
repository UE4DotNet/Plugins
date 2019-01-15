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
    ///<summary>Emitter</summary>
    public unsafe partial class Emitter : Actor  {

        ///<summary>BEGIN DEPRECATED (use component functions now in level script)</summary>
        public void Activate()  => 
            Emitter_methods.Activate_method.Invoke(ObjPointer);

        ///<summary>Deactivate</summary>
        public void Deactivate()  => 
            Emitter_methods.Deactivate_method.Invoke(ObjPointer);

        ///<summary>Is Active</summary>
        public bool IsActive()  => 
            Emitter_methods.IsActive_method.Invoke(ObjPointer);

        ///<summary>Set Actor Parameter</summary>
        public void SetActorParameter(Name ParameterName, Actor Param)  => 
            Emitter_methods.SetActorParameter_method.Invoke(ObjPointer, ParameterName, Param);

        ///<summary>Set Color Parameter</summary>
        public void SetColorParameter(Name ParameterName, LinearColor Param)  => 
            Emitter_methods.SetColorParameter_method.Invoke(ObjPointer, ParameterName, Param);

        ///<summary>Set Float Parameter</summary>
        public void SetFloatParameter(Name ParameterName, float Param)  => 
            Emitter_methods.SetFloatParameter_method.Invoke(ObjPointer, ParameterName, Param);

        ///<summary>Set Material Parameter</summary>
        public void SetMaterialParameter(Name ParameterName, MaterialInterface Param)  => 
            Emitter_methods.SetMaterialParameter_method.Invoke(ObjPointer, ParameterName, Param);

        ///<summary>Set Template</summary>
        public void SetTemplate(ParticleSystem NewTemplate)  => 
            Emitter_methods.SetTemplate_method.Invoke(ObjPointer, NewTemplate);

        ///<summary>Set Vector Parameter</summary>
        public void SetVectorParameter(Name ParameterName, Vector Param)  => 
            Emitter_methods.SetVectorParameter_method.Invoke(ObjPointer, ParameterName, Param);

        ///<summary>Toggle Active</summary>
        public void ToggleActive()  => 
            Emitter_methods.ToggleActive_method.Invoke(ObjPointer);
        ///<summary>Particle System Component</summary>
        public unsafe ParticleSystemComponent ParticleSystemComponent {
            get {return Emitter_ptr->ParticleSystemComponent;}
        }
        public bool bDestroyOnSystemFinish {
            get {return Main.GetGetBoolPropertyByName(this, "bDestroyOnSystemFinish"); }
            set {Main.SetGetBoolPropertyByName(this, "bDestroyOnSystemFinish", value); }
        }
        public bool bPostUpdateTickGroup {
            get {return Main.GetGetBoolPropertyByName(this, "bPostUpdateTickGroup"); }
            set {Main.SetGetBoolPropertyByName(this, "bPostUpdateTickGroup", value); }
        }
        public bool bCurrentlyActive {
            get {return Main.GetGetBoolPropertyByName(this, "bCurrentlyActive"); }
            set {Main.SetGetBoolPropertyByName(this, "bCurrentlyActive", value); }
        }
         //TODO: multicast delegate FParticleSpawnSignature OnParticleSpawn
         //TODO: multicast delegate FParticleBurstSignature OnParticleBurst
         //TODO: multicast delegate FParticleDeathSignature OnParticleDeath
         //TODO: multicast delegate FParticleCollisionSignature OnParticleCollide
        ///<summary>Sprite Component</summary>
        public unsafe BillboardComponent SpriteComponent {
            get {return Emitter_ptr->SpriteComponent;}
            set {Emitter_ptr->SpriteComponent = value;}
        }
        ///<summary>Arrow Component</summary>
        public unsafe ArrowComponent ArrowComponent {
            get {return Emitter_ptr->ArrowComponent;}
            set {Emitter_ptr->ArrowComponent = value;}
        }
        static Emitter() {
            StaticClass = Main.GetClass("Emitter");
        }
        internal unsafe Emitter_fields* Emitter_ptr => (Emitter_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator Emitter(IntPtr p) => UObject.Make<Emitter>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static Emitter DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static Emitter New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
