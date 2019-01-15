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
using UE4.Engine.Native;

namespace UE4.Engine {
    ///<summary>Anim State Machine Types</summary>
    public unsafe partial class AnimStateMachineTypes : UObject  {
        static AnimStateMachineTypes() {
            StaticClass = Main.GetClass("AnimStateMachineTypes");
        }
        internal unsafe AnimStateMachineTypes_fields* AnimStateMachineTypes_ptr => (AnimStateMachineTypes_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator AnimStateMachineTypes(IntPtr p) => UObject.Make<AnimStateMachineTypes>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static AnimStateMachineTypes DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static AnimStateMachineTypes New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
