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
    ///<summary>Time Limit decorator node.</summary>
    ///<remarks>A decorator node that bases its condition on whether a timer has exceeded a specified value. The timer is reset each time the node becomes relevant.</remarks>
    public unsafe partial class BTDecorator_TimeLimit : BTDecorator  {
        ///<summary>max allowed time for execution of underlying node</summary>
        public unsafe float TimeLimit {
            get {return BTDecorator_TimeLimit_ptr->TimeLimit;}
            set {BTDecorator_TimeLimit_ptr->TimeLimit = value;}
        }
        static BTDecorator_TimeLimit() {
            StaticClass = Main.GetClass("BTDecorator_TimeLimit");
        }
        internal unsafe BTDecorator_TimeLimit_fields* BTDecorator_TimeLimit_ptr => (BTDecorator_TimeLimit_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator BTDecorator_TimeLimit(IntPtr p) => UObject.Make<BTDecorator_TimeLimit>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static BTDecorator_TimeLimit DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static BTDecorator_TimeLimit New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
