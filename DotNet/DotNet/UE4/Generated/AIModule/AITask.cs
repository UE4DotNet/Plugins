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
using UE4.GameplayTasks;

namespace UE4.AIModule {
    ///<summary>AITask</summary>
    public unsafe partial class AITask : GameplayTask  {
        ///<summary>Owner Controller</summary>
        public unsafe AIController OwnerController {
            get {return AITask_ptr->OwnerController;}
        }
        static AITask() {
            StaticClass = Main.GetClass("AITask");
        }
        internal unsafe AITask_fields* AITask_ptr => (AITask_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator AITask(IntPtr p) => UObject.Make<AITask>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static AITask DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static AITask New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
