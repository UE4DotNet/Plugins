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
    ///<summary>Particle Module Event Receiver Base</summary>
    public unsafe partial class ParticleModuleEventReceiverBase : ParticleModuleEventBase  {
        ///<summary>The type of event that will generate the kill.</summary>
        public unsafe byte EventGeneratorType {
            get {return ParticleModuleEventReceiverBase_ptr->EventGeneratorType;}
            set {ParticleModuleEventReceiverBase_ptr->EventGeneratorType = value;}
        }
        ///<summary>The name of the emitter of interest for generating the event.</summary>
        public unsafe Name EventName {
            get {return ParticleModuleEventReceiverBase_ptr->EventName;}
            set {ParticleModuleEventReceiverBase_ptr->EventName = value;}
        }
        static ParticleModuleEventReceiverBase() {
            StaticClass = Main.GetClass("ParticleModuleEventReceiverBase");
        }
        internal unsafe ParticleModuleEventReceiverBase_fields* ParticleModuleEventReceiverBase_ptr => (ParticleModuleEventReceiverBase_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator ParticleModuleEventReceiverBase(IntPtr p) => UObject.Make<ParticleModuleEventReceiverBase>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static ParticleModuleEventReceiverBase DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static ParticleModuleEventReceiverBase New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
