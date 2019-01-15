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
    ///<summary>Behavior Tree Manager</summary>
    public unsafe partial class BehaviorTreeManager : UObject  {
        ///<summary>limit for recording execution steps for debugger</summary>
        public unsafe int MaxDebuggerSteps {
            get {return BehaviorTreeManager_ptr->MaxDebuggerSteps;}
            set {BehaviorTreeManager_ptr->MaxDebuggerSteps = value;}
        }
         //TODO: array not UObject TArray LoadedTemplates
        ///<summary>Active Components</summary>
        public ObjectArrayField<BehaviorTreeComponent> ActiveComponents{ get {
            if(ActiveComponents_store == null) ActiveComponents_store = new ObjectArrayField<BehaviorTreeComponent> (&BehaviorTreeManager_ptr->ActiveComponents);
            return ActiveComponents_store;
        } }
        private ObjectArrayField<BehaviorTreeComponent> ActiveComponents_store;

        static BehaviorTreeManager() {
            StaticClass = Main.GetClass("BehaviorTreeManager");
        }
        internal unsafe BehaviorTreeManager_fields* BehaviorTreeManager_ptr => (BehaviorTreeManager_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator BehaviorTreeManager(IntPtr p) => UObject.Make<BehaviorTreeManager>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static BehaviorTreeManager DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static BehaviorTreeManager New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
