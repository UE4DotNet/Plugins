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
    ///<summary>Locks AI logic until removed by external trigger</summary>
    public unsafe partial class AITask_LockLogic : AITask  {
        static AITask_LockLogic() {
            StaticClass = Main.GetClass("AITask_LockLogic");
        }
        internal unsafe AITask_LockLogic_fields* AITask_LockLogic_ptr => (AITask_LockLogic_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator AITask_LockLogic(IntPtr p) => UObject.Make<AITask_LockLogic>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static AITask_LockLogic DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static AITask_LockLogic New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
