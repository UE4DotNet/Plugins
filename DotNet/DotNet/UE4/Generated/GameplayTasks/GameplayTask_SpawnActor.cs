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
    ///<summary>Convenience task for spawning actors (optionally limiting the spawning to the network authority).</summary>
    ///<remarks>
    ///If not the net authority, we will not spawn
    ///and Success will not be called. The nice thing this adds is the ability to modify expose on spawn properties while also implicitly checking
    ///network role before spawning.
    ///
    ///Though this task doesn't do much - games can implement similar tasks that carry out game specific rules. For example a 'SpawnProjectile'
    ///task that limits the available classes to the games projectile class, and that does game specific stuff on spawn (for example, determining
    ///firing position from a weapon attachment).
    ///
    ///Long term we can also use this task as a sync point. If the executing client could wait execution until the server creates and replicates the
    ///actor down to him. We could potentially also use this to do predictive actor spawning / reconciliation.
    ///</remarks>
    public unsafe partial class GameplayTask_SpawnActor : GameplayTask  {

        ///<summary>Begin Spawning Actor</summary>
        public (Actor, bool) BeginSpawningActor(UObject WorldContextObject)  => 
            GameplayTask_SpawnActor_methods.BeginSpawningActor_method.Invoke(ObjPointer, WorldContextObject);

        ///<summary>Finish Spawning Actor</summary>
        public void FinishSpawningActor(UObject WorldContextObject, Actor SpawnedActor)  => 
            GameplayTask_SpawnActor_methods.FinishSpawningActor_method.Invoke(ObjPointer, WorldContextObject, SpawnedActor);

        ///<summary>Spawn new Actor on the network authority (server)</summary>
        public static GameplayTask_SpawnActor SpawnActor(byte TaskOwner /*TODO: interface TScriptInterface */, Vector SpawnLocation, Rotator SpawnRotation, SubclassOf<Actor> Class, bool bSpawnOnlyOnAuthority)  => 
            GameplayTask_SpawnActor_methods.SpawnActor_method.Invoke(TaskOwner, SpawnLocation, SpawnRotation, Class, bSpawnOnlyOnAuthority);
         //TODO: multicast delegate FGameplayTaskSpawnActorDelegate Success
         //TODO: multicast delegate FGameplayTaskSpawnActorDelegate DidNotSpawn
        ///<summary>Class to Spawn</summary>
        public unsafe SubclassOf<Actor> ClassToSpawn {
            get {return GameplayTask_SpawnActor_ptr->ClassToSpawn;}
            set {GameplayTask_SpawnActor_ptr->ClassToSpawn = value;}
        }
        static GameplayTask_SpawnActor() {
            StaticClass = Main.GetClass("GameplayTask_SpawnActor");
        }
        internal unsafe GameplayTask_SpawnActor_fields* GameplayTask_SpawnActor_ptr => (GameplayTask_SpawnActor_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator GameplayTask_SpawnActor(IntPtr p) => UObject.Make<GameplayTask_SpawnActor>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static GameplayTask_SpawnActor DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static GameplayTask_SpawnActor New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
