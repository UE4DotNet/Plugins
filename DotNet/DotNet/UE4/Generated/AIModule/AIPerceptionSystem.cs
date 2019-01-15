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
    ///<summary>By design checks perception between hostile teams</summary>
    public unsafe partial class AIPerceptionSystem : UObject  {

        ///<summary>Get Sense Class for Stimulus</summary>
        public static SubclassOf<AISense> GetSenseClassForStimulus(UObject WorldContextObject, AIStimulus Stimulus)  => 
            AIPerceptionSystem_methods.GetSenseClassForStimulus_method.Invoke(WorldContextObject, Stimulus);

        ///<summary>Register Perception Stimuli Source</summary>
        public static bool RegisterPerceptionStimuliSource(UObject WorldContextObject, SubclassOf<AISense> Sense, Actor Target)  => 
            AIPerceptionSystem_methods.RegisterPerceptionStimuliSource_method.Invoke(WorldContextObject, Sense, Target);

        ///<summary>Report Event</summary>
        public void ReportEvent(AISenseEvent PerceptionEvent)  => 
            AIPerceptionSystem_methods.ReportEvent_method.Invoke(ObjPointer, PerceptionEvent);

        ///<summary>Report Perception Event</summary>
        public static void ReportPerceptionEvent(UObject WorldContextObject, AISenseEvent PerceptionEvent)  => 
            AIPerceptionSystem_methods.ReportPerceptionEvent_method.Invoke(WorldContextObject, PerceptionEvent);
        ///<summary>Senses</summary>
        public ObjectArrayField<AISense> Senses{ get {
            if(Senses_store == null) Senses_store = new ObjectArrayField<AISense> (&AIPerceptionSystem_ptr->Senses);
            return Senses_store;
        } }
        private ObjectArrayField<AISense> Senses_store;

        ///<summary>Perception Aging Rate</summary>
        public unsafe float PerceptionAgingRate {
            get {return AIPerceptionSystem_ptr->PerceptionAgingRate;}
            set {AIPerceptionSystem_ptr->PerceptionAgingRate = value;}
        }
        static AIPerceptionSystem() {
            StaticClass = Main.GetClass("AIPerceptionSystem");
        }
        internal unsafe AIPerceptionSystem_fields* AIPerceptionSystem_ptr => (AIPerceptionSystem_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator AIPerceptionSystem(IntPtr p) => UObject.Make<AIPerceptionSystem>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static AIPerceptionSystem DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static AIPerceptionSystem New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
