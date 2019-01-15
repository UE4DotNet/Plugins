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
    ///<summary>Conditional loop decorator node.</summary>
    ///<remarks>A decorator node that loops execution as long as condition is satisfied.</remarks>
    public unsafe partial class BTDecorator_ConditionalLoop : BTDecorator_Blackboard  {
        static BTDecorator_ConditionalLoop() {
            StaticClass = Main.GetClass("BTDecorator_ConditionalLoop");
        }
        internal unsafe BTDecorator_ConditionalLoop_fields* BTDecorator_ConditionalLoop_ptr => (BTDecorator_ConditionalLoop_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator BTDecorator_ConditionalLoop(IntPtr p) => UObject.Make<BTDecorator_ConditionalLoop>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static BTDecorator_ConditionalLoop DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static BTDecorator_ConditionalLoop New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
