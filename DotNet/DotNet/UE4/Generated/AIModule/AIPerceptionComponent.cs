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
    ///<summary>
    ///AIPerceptionComponent is used to register as stimuli listener in AIPerceptionSystem
    ///and gathers registered stimuli.
    ///</summary>
    ///<remarks>UpdatePerception is called when component gets new stimuli (batched)</remarks>
    public unsafe partial class AIPerceptionComponent : ActorComponent  {

        ///<summary>Retrieves whatever has been sensed about given actor</summary>
        public (ActorPerceptionBlueprintInfo, bool) GetActorsPerception(Actor Actor)  => 
            AIPerceptionComponent_methods.GetActorsPerception_method.Invoke(ObjPointer, Actor);

        ///<summary>If SenseToUse is none all actors currently perceived in any way will get fetched</summary>
        public IReadOnlyCollection<Actor> GetCurrentlyPerceivedActors(SubclassOf<AISense> SenseToUse)  => 
            AIPerceptionComponent_methods.GetCurrentlyPerceivedActors_method.Invoke(ObjPointer, SenseToUse);

        ///<summary>If SenseToUse is none all actors ever perceived in any way (and not forgotten yet) will get fetched</summary>
        public IReadOnlyCollection<Actor> GetKnownPerceivedActors(SubclassOf<AISense> SenseToUse)  => 
            AIPerceptionComponent_methods.GetKnownPerceivedActors_method.Invoke(ObjPointer, SenseToUse);

        ///<summary>Get Perceived Actors</summary>
        public IReadOnlyCollection<Actor> GetPerceivedActors(SubclassOf<AISense> SenseToUse)  => 
            AIPerceptionComponent_methods.GetPerceivedActors_method.Invoke(ObjPointer, SenseToUse);

        ///<summary>blueprint interface</summary>
        public IReadOnlyCollection<Actor> GetPerceivedHostileActors()  => 
            AIPerceptionComponent_methods.GetPerceivedHostileActors_method.Invoke(ObjPointer);

        ///<summary>Notifies AIPerceptionSystem to update properties for this "stimuli listener"</summary>
        public void RequestStimuliListenerUpdate()  => 
            AIPerceptionComponent_methods.RequestStimuliListenerUpdate_method.Invoke(ObjPointer);

        ///<summary>Note that this works only if given sense has been already configured for</summary>
        ///<remarks>this component instance</remarks>
        public void SetSenseEnabled(SubclassOf<AISense> SenseClass, bool bEnable)  => 
            AIPerceptionComponent_methods.SetSenseEnabled_method.Invoke(ObjPointer, SenseClass, bEnable);
        ///<summary>Senses Config</summary>
        public ObjectArrayField<AISenseConfig> SensesConfig{ get {
            if(SensesConfig_store == null) SensesConfig_store = new ObjectArrayField<AISenseConfig> (&AIPerceptionComponent_ptr->SensesConfig);
            return SensesConfig_store;
        } }
        private ObjectArrayField<AISenseConfig> SensesConfig_store;

        ///<summary>Indicated sense that takes precedence over other senses when determining sensed actor's location.</summary>
        ///<remarks>Should be set to one of the senses configured in SensesConfig, or None.</remarks>
        public unsafe SubclassOf<AISense> DominantSense {
            get {return AIPerceptionComponent_ptr->DominantSense;}
            set {AIPerceptionComponent_ptr->DominantSense = value;}
        }
        ///<summary>AIOwner</summary>
        public unsafe AIController AIOwner {
            get {return AIPerceptionComponent_ptr->AIOwner;}
            set {AIPerceptionComponent_ptr->AIOwner = value;}
        }
         //TODO: multicast delegate FPerceptionUpdatedDelegate OnPerceptionUpdated
         //TODO: multicast delegate FActorPerceptionUpdatedDelegate OnTargetPerceptionUpdated
        static AIPerceptionComponent() {
            StaticClass = Main.GetClass("AIPerceptionComponent");
        }
        internal unsafe AIPerceptionComponent_fields* AIPerceptionComponent_ptr => (AIPerceptionComponent_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator AIPerceptionComponent(IntPtr p) => UObject.Make<AIPerceptionComponent>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static AIPerceptionComponent DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static AIPerceptionComponent New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
