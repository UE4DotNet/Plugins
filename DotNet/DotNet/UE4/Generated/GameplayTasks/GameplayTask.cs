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
    ///<summary>Gameplay Task</summary>
    public unsafe partial class GameplayTask : UObject  {

        ///<summary>Called explicitly to end the task (usually by the task itself).</summary>
        ///<remarks>
        ///Calls OnDestroy.
        ///    @NOTE: you need to call EndTask before sending out any "on completed" delegates.
        ///    If you don't the task will still be in an "active" state while the event receivers may
        ///    assume it's already "finished"
        ///</remarks>
        public void EndTask()  => 
            GameplayTask_methods.EndTask_method.Invoke(ObjPointer);

        ///<summary>Called to trigger the actual task once the delegates have been set up</summary>
        public void ReadyForActivation()  => 
            GameplayTask_methods.ReadyForActivation_method.Invoke(ObjPointer);
        ///<summary>This name allows us to find the task later so that we can end it.</summary>
        public unsafe Name InstanceName {
            get {return GameplayTask_ptr->InstanceName;}
            set {GameplayTask_ptr->InstanceName = value;}
        }
         //TODO: enum ETaskResourceOverlapPolicy ResourceOverlapPolicy
        ///<summary>child task instance</summary>
        public unsafe GameplayTask ChildTask {
            get {return GameplayTask_ptr->ChildTask;}
            set {GameplayTask_ptr->ChildTask = value;}
        }
        static GameplayTask() {
            StaticClass = Main.GetClass("GameplayTask");
        }
        internal unsafe GameplayTask_fields* GameplayTask_ptr => (GameplayTask_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator GameplayTask(IntPtr p) => UObject.Make<GameplayTask>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static GameplayTask DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static GameplayTask New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
