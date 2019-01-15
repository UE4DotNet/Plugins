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
using UE4.GameplayDebugger.Native;
using UE4.Engine;

namespace UE4.GameplayDebugger {
    ///<summary>Gameplay Debugger Local Controller</summary>
    public unsafe partial class GameplayDebuggerLocalController : UObject  {
        ///<summary>Cached Replicator</summary>
        public unsafe GameplayDebuggerCategoryReplicator CachedReplicator {
            get {return GameplayDebuggerLocalController_ptr->CachedReplicator;}
            set {GameplayDebuggerLocalController_ptr->CachedReplicator = value;}
        }
        ///<summary>Cached Player Manager</summary>
        public unsafe GameplayDebuggerPlayerManager CachedPlayerManager {
            get {return GameplayDebuggerLocalController_ptr->CachedPlayerManager;}
            set {GameplayDebuggerLocalController_ptr->CachedPlayerManager = value;}
        }
        ///<summary>Debug Actor Candidate</summary>
        public unsafe Actor DebugActorCandidate {
            get {return GameplayDebuggerLocalController_ptr->DebugActorCandidate;}
            set {GameplayDebuggerLocalController_ptr->DebugActorCandidate = value;}
        }
        static GameplayDebuggerLocalController() {
            StaticClass = Main.GetClass("GameplayDebuggerLocalController");
        }
        internal unsafe GameplayDebuggerLocalController_fields* GameplayDebuggerLocalController_ptr => (GameplayDebuggerLocalController_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator GameplayDebuggerLocalController(IntPtr p) => UObject.Make<GameplayDebuggerLocalController>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static GameplayDebuggerLocalController DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static GameplayDebuggerLocalController New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
