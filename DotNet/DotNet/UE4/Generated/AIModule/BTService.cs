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

namespace UE4.AIModule {
    ///<summary>Behavior Tree service nodes is designed to perform "background" tasks that update AI's knowledge.</summary>
    ///<remarks>
    ///Services are being executed when underlying branch of behavior tree becomes active,
    ///but unlike tasks they don't return any results and can't directly affect execution flow.
    ///
    ///Usually they perform periodical checks (see TickNode) and often store results in blackboard.
    ///If any decorator node below requires results of check beforehand, use OnSearchStart function.
    ///Keep in mind that any checks performed there have to be instantaneous!
    ///
    ///Other typical use case is creating a marker when specific branch is being executed
    ///(see OnBecomeRelevant, OnCeaseRelevant), by setting a flag in blackboard.
    ///
    ///Because some of them can be instanced for specific AI, following virtual functions are not marked as const:
    ///- OnBecomeRelevant (from UBTAuxiliaryNode)
    ///- OnCeaseRelevant (from UBTAuxiliaryNode)
    ///- TickNode (from UBTAuxiliaryNode)
    ///- OnSearchStart
    ///
    ///If your node is not being instanced (default behavior), DO NOT change any properties of object within those functions!
    ///Template nodes are shared across all behavior tree components using the same tree asset and must store
    ///their runtime properties in provided NodeMemory block (allocation size determined by GetInstanceMemorySize() )
    ///</remarks>
    public unsafe partial class BTService : BTAuxiliaryNode  {
        ///<summary>defines time span between subsequent ticks of the service</summary>
        public unsafe float Interval {
            get {return BTService_ptr->Interval;}
            set {BTService_ptr->Interval = value;}
        }
        ///<summary>adds random range to service's Interval</summary>
        public unsafe float RandomDeviation {
            get {return BTService_ptr->RandomDeviation;}
            set {BTService_ptr->RandomDeviation = value;}
        }
        public bool bCallTickOnSearchStart {
            get {return Main.GetGetBoolPropertyByName(this, "bCallTickOnSearchStart"); }
            set {Main.SetGetBoolPropertyByName(this, "bCallTickOnSearchStart", value); }
        }
        public bool bRestartTimerOnEachActivation {
            get {return Main.GetGetBoolPropertyByName(this, "bRestartTimerOnEachActivation"); }
            set {Main.SetGetBoolPropertyByName(this, "bRestartTimerOnEachActivation", value); }
        }
        static BTService() {
            StaticClass = Main.GetClass("BTService");
        }
        internal unsafe BTService_fields* BTService_ptr => (BTService_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator BTService(IntPtr p) => UObject.Make<BTService>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static BTService DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static BTService New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
