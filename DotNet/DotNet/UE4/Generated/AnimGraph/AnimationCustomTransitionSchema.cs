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

namespace UE4.AnimGraph {
    ///<summary>Animation Custom Transition Schema</summary>
    public unsafe partial class AnimationCustomTransitionSchema : AnimationGraphSchema  {
        static AnimationCustomTransitionSchema() {
            StaticClass = Main.GetClass("AnimationCustomTransitionSchema");
        }
        internal unsafe AnimationCustomTransitionSchema_fields* AnimationCustomTransitionSchema_ptr => (AnimationCustomTransitionSchema_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator AnimationCustomTransitionSchema(IntPtr p) => UObject.Make<AnimationCustomTransitionSchema>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static AnimationCustomTransitionSchema DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static AnimationCustomTransitionSchema New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
