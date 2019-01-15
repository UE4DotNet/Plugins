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
using UE4.AnimGraph.Native;
using UE4.Engine;

namespace UE4.AnimGraph {
    ///<summary>Animation State Machine Schema</summary>
    public unsafe partial class AnimationStateMachineSchema : EdGraphSchema  {
        static AnimationStateMachineSchema() {
            StaticClass = Main.GetClass("AnimationStateMachineSchema");
        }
        internal unsafe AnimationStateMachineSchema_fields* AnimationStateMachineSchema_ptr => (AnimationStateMachineSchema_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator AnimationStateMachineSchema(IntPtr p) => UObject.Make<AnimationStateMachineSchema>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static AnimationStateMachineSchema DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static AnimationStateMachineSchema New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
