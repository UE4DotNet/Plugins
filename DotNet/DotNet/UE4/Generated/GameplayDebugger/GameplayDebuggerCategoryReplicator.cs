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
    ///<summary>Gameplay Debugger Category Replicator</summary>
    public unsafe partial class GameplayDebuggerCategoryReplicator : Actor  {
        ///<summary>Owner PC</summary>
        public unsafe PlayerController OwnerPC {
            get {return GameplayDebuggerCategoryReplicator_ptr->OwnerPC;}
            set {GameplayDebuggerCategoryReplicator_ptr->OwnerPC = value;}
        }
        public bool bIsEnabled {
            get {return Main.GetGetBoolPropertyByName(this, "bIsEnabled"); }
            set {Main.SetGetBoolPropertyByName(this, "bIsEnabled", value); }
        }
        ///<summary>Replicated Data</summary>
        public unsafe GameplayDebuggerNetPack ReplicatedData {
            get {return GameplayDebuggerCategoryReplicator_ptr->ReplicatedData;}
            set {GameplayDebuggerCategoryReplicator_ptr->ReplicatedData = value;}
        }
        ///<summary>Debug Actor</summary>
        public unsafe GameplayDebuggerDebugActor DebugActor {
            get {return GameplayDebuggerCategoryReplicator_ptr->DebugActor;}
            set {GameplayDebuggerCategoryReplicator_ptr->DebugActor = value;}
        }
        ///<summary>rendering component needs to attached to some actor, and this is as good as any</summary>
        public unsafe GameplayDebuggerRenderingComponent RenderingComp {
            get {return GameplayDebuggerCategoryReplicator_ptr->RenderingComp;}
            set {GameplayDebuggerCategoryReplicator_ptr->RenderingComp = value;}
        }
        static GameplayDebuggerCategoryReplicator() {
            StaticClass = Main.GetClass("GameplayDebuggerCategoryReplicator");
        }
        internal unsafe GameplayDebuggerCategoryReplicator_fields* GameplayDebuggerCategoryReplicator_ptr => (GameplayDebuggerCategoryReplicator_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator GameplayDebuggerCategoryReplicator(IntPtr p) => UObject.Make<GameplayDebuggerCategoryReplicator>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static GameplayDebuggerCategoryReplicator DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static GameplayDebuggerCategoryReplicator New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
