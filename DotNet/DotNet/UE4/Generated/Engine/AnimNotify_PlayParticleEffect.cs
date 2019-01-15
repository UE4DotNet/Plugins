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
    ///<summary>Anim Notify Play Particle Effect</summary>
    public unsafe partial class AnimNotify_PlayParticleEffect : AnimNotify  {
        ///<summary>Particle System to Spawn</summary>
        public unsafe ParticleSystem PSTemplate {
            get {return AnimNotify_PlayParticleEffect_ptr->PSTemplate;}
        }
        ///<summary>Location offset from the socket</summary>
        public unsafe Vector LocationOffset {
            get {return AnimNotify_PlayParticleEffect_ptr->LocationOffset;}
        }
        ///<summary>Rotation offset from socket</summary>
        public unsafe Rotator RotationOffset {
            get {return AnimNotify_PlayParticleEffect_ptr->RotationOffset;}
        }
        ///<summary>Scale to spawn the particle system at</summary>
        public unsafe Vector Scale {
            get {return AnimNotify_PlayParticleEffect_ptr->Scale;}
        }
        public bool Attached {
            get {return Main.GetGetBoolPropertyByName(this, "Attached"); }
        }
        ///<summary>SocketName to attach to</summary>
        public unsafe Name SocketName {
            get {return AnimNotify_PlayParticleEffect_ptr->SocketName;}
        }
        static AnimNotify_PlayParticleEffect() {
            StaticClass = Main.GetClass("AnimNotify_PlayParticleEffect");
        }
        internal unsafe AnimNotify_PlayParticleEffect_fields* AnimNotify_PlayParticleEffect_ptr => (AnimNotify_PlayParticleEffect_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator AnimNotify_PlayParticleEffect(IntPtr p) => UObject.Make<AnimNotify_PlayParticleEffect>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static AnimNotify_PlayParticleEffect DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static AnimNotify_PlayParticleEffect New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
