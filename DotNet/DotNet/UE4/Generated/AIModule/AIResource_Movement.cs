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
    ///<summary>AIResource Movement</summary>
    public unsafe partial class AIResource_Movement : GameplayTaskResource  {
        static AIResource_Movement() {
            StaticClass = Main.GetClass("AIResource_Movement");
        }
        internal unsafe AIResource_Movement_fields* AIResource_Movement_ptr => (AIResource_Movement_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator AIResource_Movement(IntPtr p) => UObject.Make<AIResource_Movement>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static AIResource_Movement DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static AIResource_Movement New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
