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
    ///<summary>Gameplay Debugger Player Manager</summary>
    public unsafe partial class GameplayDebuggerPlayerManager : Actor  {
         //TODO: array not UObject TArray PlayerData
        ///<summary>Pending Registrations</summary>
        public ObjectArrayField<GameplayDebuggerCategoryReplicator> PendingRegistrations{ get {
            if(PendingRegistrations_store == null) PendingRegistrations_store = new ObjectArrayField<GameplayDebuggerCategoryReplicator> (&GameplayDebuggerPlayerManager_ptr->PendingRegistrations);
            return PendingRegistrations_store;
        } }
        private ObjectArrayField<GameplayDebuggerCategoryReplicator> PendingRegistrations_store;

        static GameplayDebuggerPlayerManager() {
            StaticClass = Main.GetClass("GameplayDebuggerPlayerManager");
        }
        internal unsafe GameplayDebuggerPlayerManager_fields* GameplayDebuggerPlayerManager_ptr => (GameplayDebuggerPlayerManager_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator GameplayDebuggerPlayerManager(IntPtr p) => UObject.Make<GameplayDebuggerPlayerManager>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static GameplayDebuggerPlayerManager DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static GameplayDebuggerPlayerManager New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
