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
    ///<summary>Instantly finishes with given result</summary>
    public unsafe partial class BTTask_FinishWithResult : BTTaskNode  {
        ///<summary>allows adding random time to wait time</summary>
        public unsafe byte Result {
            get {return BTTask_FinishWithResult_ptr->Result;}
            set {BTTask_FinishWithResult_ptr->Result = value;}
        }
        static BTTask_FinishWithResult() {
            StaticClass = Main.GetClass("BTTask_FinishWithResult");
        }
        internal unsafe BTTask_FinishWithResult_fields* BTTask_FinishWithResult_ptr => (BTTask_FinishWithResult_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator BTTask_FinishWithResult(IntPtr p) => UObject.Make<BTTask_FinishWithResult>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static BTTask_FinishWithResult DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static BTTask_FinishWithResult New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
