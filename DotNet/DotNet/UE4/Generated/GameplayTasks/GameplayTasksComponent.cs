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
using UE4.Engine;

namespace UE4.GameplayTasks {
    ///<summary>The core ActorComponent for interfacing with the GameplayAbilities System</summary>
    public unsafe partial class GameplayTasksComponent : ActorComponent  {

        ///<summary>END IGameplayTaskOwnerInterface</summary>
        public static EGameplayTaskRunResult K2_RunGameplayTask(byte TaskOwner /*TODO: interface TScriptInterface */, GameplayTask Task, byte Priority, byte AdditionalRequiredResources /*TODO: array TArray */, byte AdditionalClaimedResources /*TODO: array TArray */)  => 
            GameplayTasksComponent_methods.K2_RunGameplayTask_method.Invoke(TaskOwner, Task, Priority, AdditionalRequiredResources, AdditionalClaimedResources);
        public bool bIsNetDirty {
            get {return Main.GetGetBoolPropertyByName(this, "bIsNetDirty"); }
            set {Main.SetGetBoolPropertyByName(this, "bIsNetDirty", value); }
        }
        ///<summary>Tasks that run on simulated proxies</summary>
        public ObjectArrayField<GameplayTask> SimulatedTasks{ get {
            if(SimulatedTasks_store == null) SimulatedTasks_store = new ObjectArrayField<GameplayTask> (&GameplayTasksComponent_ptr->SimulatedTasks);
            return SimulatedTasks_store;
        } }
        private ObjectArrayField<GameplayTask> SimulatedTasks_store;

        ///<summary>Task Priority Queue</summary>
        public ObjectArrayField<GameplayTask> TaskPriorityQueue{ get {
            if(TaskPriorityQueue_store == null) TaskPriorityQueue_store = new ObjectArrayField<GameplayTask> (&GameplayTasksComponent_ptr->TaskPriorityQueue);
            return TaskPriorityQueue_store;
        } }
        private ObjectArrayField<GameplayTask> TaskPriorityQueue_store;

        ///<summary>Array of currently active UGameplayTask that require ticking</summary>
        public ObjectArrayField<GameplayTask> TickingTasks{ get {
            if(TickingTasks_store == null) TickingTasks_store = new ObjectArrayField<GameplayTask> (&GameplayTasksComponent_ptr->TickingTasks);
            return TickingTasks_store;
        } }
        private ObjectArrayField<GameplayTask> TickingTasks_store;

        ///<summary>All known tasks (processed by this component) referenced for GC</summary>
        public ObjectArrayField<GameplayTask> KnownTasks{ get {
            if(KnownTasks_store == null) KnownTasks_store = new ObjectArrayField<GameplayTask> (&GameplayTasksComponent_ptr->KnownTasks);
            return KnownTasks_store;
        } }
        private ObjectArrayField<GameplayTask> KnownTasks_store;

         //TODO: multicast delegate FOnClaimedResourcesChangeSignature OnClaimedResourcesChange
        static GameplayTasksComponent() {
            StaticClass = Main.GetClass("GameplayTasksComponent");
        }
        internal unsafe GameplayTasksComponent_fields* GameplayTasksComponent_ptr => (GameplayTasksComponent_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator GameplayTasksComponent(IntPtr p) => UObject.Make<GameplayTasksComponent>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static GameplayTasksComponent DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static GameplayTasksComponent New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
