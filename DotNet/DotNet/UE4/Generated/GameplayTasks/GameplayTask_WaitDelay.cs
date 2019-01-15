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
    ///<summary>Gameplay Task Wait Delay</summary>
    public unsafe partial class GameplayTask_WaitDelay : GameplayTask  {

        ///<summary>Wait specified time. This is functionally the same as a standard Delay node.</summary>
        public static GameplayTask_WaitDelay TaskWaitDelay(byte TaskOwner /*TODO: interface TScriptInterface */, float Time, byte Priority)  => 
            GameplayTask_WaitDelay_methods.TaskWaitDelay_method.Invoke(TaskOwner, Time, Priority);
         //TODO: multicast delegate FTaskDelayDelegate OnFinish
        static GameplayTask_WaitDelay() {
            StaticClass = Main.GetClass("GameplayTask_WaitDelay");
        }
        internal unsafe GameplayTask_WaitDelay_fields* GameplayTask_WaitDelay_ptr => (GameplayTask_WaitDelay_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator GameplayTask_WaitDelay(IntPtr p) => UObject.Make<GameplayTask_WaitDelay>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static GameplayTask_WaitDelay DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static GameplayTask_WaitDelay New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
