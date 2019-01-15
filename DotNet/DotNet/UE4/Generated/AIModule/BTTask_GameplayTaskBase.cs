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
    ///<summary>
    ///Base class for managing gameplay tasks
    ///Since AITask doesn't have any kind of success/failed results, default implemenation will only return EBTNode::Succeeded
    ///In your ExecuteTask:
    ///- use NewBTAITask() helper to create task
    ///- initialize task with values if needed
    ///</summary>
    ///<remarks>- use StartGameplayTask() helper to execute and get node result</remarks>
    public unsafe partial class BTTask_GameplayTaskBase : BTTaskNode  {
        public bool bWaitForGameplayTask {
            get {return Main.GetGetBoolPropertyByName(this, "bWaitForGameplayTask"); }
            set {Main.SetGetBoolPropertyByName(this, "bWaitForGameplayTask", value); }
        }
        static BTTask_GameplayTaskBase() {
            StaticClass = Main.GetClass("BTTask_GameplayTaskBase");
        }
        internal unsafe BTTask_GameplayTaskBase_fields* BTTask_GameplayTaskBase_ptr => (BTTask_GameplayTaskBase_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator BTTask_GameplayTaskBase(IntPtr p) => UObject.Make<BTTask_GameplayTaskBase>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static BTTask_GameplayTaskBase DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static BTTask_GameplayTaskBase New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
