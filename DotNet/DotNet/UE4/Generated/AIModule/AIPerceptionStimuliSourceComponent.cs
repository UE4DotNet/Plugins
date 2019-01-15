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
using UE4.AIModule.Native;
using UE4.Engine;

namespace UE4.AIModule {
    ///<summary>Gives owning actor a way to auto-register as perception system's sense stimuli source</summary>
    public unsafe partial class AIPerceptionStimuliSourceComponent : ActorComponent  {

        ///<summary>Registers owning actor as source for specified sense class</summary>
        public void RegisterForSense(SubclassOf<AISense> SenseClass)  => 
            AIPerceptionStimuliSourceComponent_methods.RegisterForSense_method.Invoke(ObjPointer, SenseClass);

        ///<summary>Registers owning actor as source of stimuli for senses specified in RegisterAsSourceForSenses.</summary>
        ///<remarks>Note that you don't have to do it if bAutoRegisterAsSource == true</remarks>
        public void RegisterWithPerceptionSystem()  => 
            AIPerceptionStimuliSourceComponent_methods.RegisterWithPerceptionSystem_method.Invoke(ObjPointer);

        ///<summary>Unregister owning actor from being a source of sense stimuli</summary>
        public void UnregisterFromPerceptionSystem()  => 
            AIPerceptionStimuliSourceComponent_methods.UnregisterFromPerceptionSystem_method.Invoke(ObjPointer);

        ///<summary>Unregisters owning actor from sources list of a specified sense class</summary>
        public void UnregisterFromSense(SubclassOf<AISense> SenseClass)  => 
            AIPerceptionStimuliSourceComponent_methods.UnregisterFromSense_method.Invoke(ObjPointer, SenseClass);
        public bool bAutoRegisterAsSource {
            get {return Main.GetGetBoolPropertyByName(this, "bAutoRegisterAsSource"); }
        }
        ///<summary>Register as Source for Senses</summary>
        public ObjectArrayField<Class> RegisterAsSourceForSenses{ get {
            if(RegisterAsSourceForSenses_store == null) RegisterAsSourceForSenses_store = new ObjectArrayField<Class> (&AIPerceptionStimuliSourceComponent_ptr->RegisterAsSourceForSenses);
            return RegisterAsSourceForSenses_store;
        } }
        private ObjectArrayField<Class> RegisterAsSourceForSenses_store;

        static AIPerceptionStimuliSourceComponent() {
            StaticClass = Main.GetClass("AIPerceptionStimuliSourceComponent");
        }
        internal unsafe AIPerceptionStimuliSourceComponent_fields* AIPerceptionStimuliSourceComponent_ptr => (AIPerceptionStimuliSourceComponent_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator AIPerceptionStimuliSourceComponent(IntPtr p) => UObject.Make<AIPerceptionStimuliSourceComponent>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static AIPerceptionStimuliSourceComponent DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static AIPerceptionStimuliSourceComponent New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
