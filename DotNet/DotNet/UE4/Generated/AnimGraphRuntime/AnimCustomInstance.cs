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
using UE4.AnimGraphRuntime.Native;
using UE4.Engine;

namespace UE4.AnimGraphRuntime {
    ///<summary>Anim Custom Instance</summary>
    public unsafe partial class AnimCustomInstance : AnimInstance  {
        static AnimCustomInstance() {
            StaticClass = Main.GetClass("AnimCustomInstance");
        }
        internal unsafe AnimCustomInstance_fields* AnimCustomInstance_ptr => (AnimCustomInstance_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator AnimCustomInstance(IntPtr p) => UObject.Make<AnimCustomInstance>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static AnimCustomInstance DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static AnimCustomInstance New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
