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
using UE4.GameplayTasks.Native;

namespace UE4.GameplayTasks {
    ///<summary>
    ///Adds time limit for running a child task
    ///- child task needs to be created with UGameplayTask_TimeLimitedExecution passed as TaskOwner
    ///- activations are tied together and when either UGameplayTask_TimeLimitedExecution or child task is activated, other one starts as well
    ///</summary>
    ///<remarks>- OnFinished and OnTimeExpired are mutually exclusive</remarks>
    public unsafe partial class GameplayTask_TimeLimitedExecution : GameplayTask  {
         //TODO: multicast delegate FTaskFinishDelegate OnFinished
         //TODO: multicast delegate FTaskFinishDelegate OnTimeExpired
        static GameplayTask_TimeLimitedExecution() {
            StaticClass = Main.GetClass("GameplayTask_TimeLimitedExecution");
        }
        internal unsafe GameplayTask_TimeLimitedExecution_fields* GameplayTask_TimeLimitedExecution_ptr => (GameplayTask_TimeLimitedExecution_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator GameplayTask_TimeLimitedExecution(IntPtr p) => UObject.Make<GameplayTask_TimeLimitedExecution>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static GameplayTask_TimeLimitedExecution DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static GameplayTask_TimeLimitedExecution New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
