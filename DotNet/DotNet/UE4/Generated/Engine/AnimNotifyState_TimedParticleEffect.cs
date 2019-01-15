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
    ///<summary>
    ///Timed Particle Effect Notify
    ///Allows a looping particle effect to be played in an animation that will activate
    ///at the beginning of the notify and deactivate at the end.
    ///</summary>
    public unsafe partial class AnimNotifyState_TimedParticleEffect : AnimNotifyState  {
        ///<summary>The particle system to spawn for the notify state</summary>
        public unsafe ParticleSystem PSTemplate {
            get {return AnimNotifyState_TimedParticleEffect_ptr->PSTemplate;}
        }
        ///<summary>The socket or bone to attach the system to</summary>
        public unsafe Name SocketName {
            get {return AnimNotifyState_TimedParticleEffect_ptr->SocketName;}
        }
        ///<summary>Offset from the socket or bone to place the particle system</summary>
        public unsafe Vector LocationOffset {
            get {return AnimNotifyState_TimedParticleEffect_ptr->LocationOffset;}
        }
        ///<summary>Rotation offset from the socket or bone for the particle system</summary>
        public unsafe Rotator RotationOffset {
            get {return AnimNotifyState_TimedParticleEffect_ptr->RotationOffset;}
        }
        public bool bDestroyAtEnd {
            get {return Main.GetGetBoolPropertyByName(this, "bDestroyAtEnd"); }
        }
        ///<summary>The following arrays are used to handle property changes during a state.</summary>
        ///<remarks>
        ///Because we can't
        ///store any stateful data here we can't know which emitter is ours. The best metric we have
        ///is an emitter on our Mesh Component with the same template and socket name we have defined.
        ///Because these can change at any time we need to track previous versions when we are in an
        ///editor build. Refactor when stateful data is possible, tracking our component instead.
        ///</remarks>
        public ObjectArrayField<ParticleSystem> PreviousPSTemplates{ get {
            if(PreviousPSTemplates_store == null) PreviousPSTemplates_store = new ObjectArrayField<ParticleSystem> (&AnimNotifyState_TimedParticleEffect_ptr->PreviousPSTemplates);
            return PreviousPSTemplates_store;
        } }
        private ObjectArrayField<ParticleSystem> PreviousPSTemplates_store;

         //TODO: array not UObject TArray PreviousSocketNames
        static AnimNotifyState_TimedParticleEffect() {
            StaticClass = Main.GetClass("AnimNotifyState_TimedParticleEffect");
        }
        internal unsafe AnimNotifyState_TimedParticleEffect_fields* AnimNotifyState_TimedParticleEffect_ptr => (AnimNotifyState_TimedParticleEffect_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator AnimNotifyState_TimedParticleEffect(IntPtr p) => UObject.Make<AnimNotifyState_TimedParticleEffect>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static AnimNotifyState_TimedParticleEffect DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static AnimNotifyState_TimedParticleEffect New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
