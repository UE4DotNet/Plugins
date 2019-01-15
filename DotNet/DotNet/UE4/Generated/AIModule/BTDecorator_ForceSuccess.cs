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
    ///<summary>
    ///Change node result to Success
    ///useful for creating optional branches in sequence
    ///Forcing failed result was not implemented, because it doesn't make sense in both basic composites:
    ///- sequence = child nodes behind it will be never run
    ///- selector = would allow executing multiple nodes, turning it into a sequence.
    ///</summary>
    ///<remarks>..</remarks>
    public unsafe partial class BTDecorator_ForceSuccess : BTDecorator  {
        static BTDecorator_ForceSuccess() {
            StaticClass = Main.GetClass("BTDecorator_ForceSuccess");
        }
        internal unsafe BTDecorator_ForceSuccess_fields* BTDecorator_ForceSuccess_ptr => (BTDecorator_ForceSuccess_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator BTDecorator_ForceSuccess(IntPtr p) => UObject.Make<BTDecorator_ForceSuccess>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static BTDecorator_ForceSuccess DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static BTDecorator_ForceSuccess New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
