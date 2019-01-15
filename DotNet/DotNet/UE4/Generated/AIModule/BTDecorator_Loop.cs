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
    ///<summary>Loop decorator node.</summary>
    ///<remarks>A decorator node that bases its condition on whether its loop counter has been exceeded.</remarks>
    public unsafe partial class BTDecorator_Loop : BTDecorator  {
        ///<summary>number of executions</summary>
        public unsafe int NumLoops {
            get {return BTDecorator_Loop_ptr->NumLoops;}
            set {BTDecorator_Loop_ptr->NumLoops = value;}
        }
        public bool bInfiniteLoop {
            get {return Main.GetGetBoolPropertyByName(this, "bInfiniteLoop"); }
            set {Main.SetGetBoolPropertyByName(this, "bInfiniteLoop", value); }
        }
        ///<summary>timeout (when looping infinitely, when we finish a loop we will check whether we have spent this time looping, if we have we will stop looping). A negative value means loop forever.</summary>
        public unsafe float InfiniteLoopTimeoutTime {
            get {return BTDecorator_Loop_ptr->InfiniteLoopTimeoutTime;}
            set {BTDecorator_Loop_ptr->InfiniteLoopTimeoutTime = value;}
        }
        static BTDecorator_Loop() {
            StaticClass = Main.GetClass("BTDecorator_Loop");
        }
        internal unsafe BTDecorator_Loop_fields* BTDecorator_Loop_ptr => (BTDecorator_Loop_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator BTDecorator_Loop(IntPtr p) => UObject.Make<BTDecorator_Loop>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static BTDecorator_Loop DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static BTDecorator_Loop New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
