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
using UE4.BlueprintGraph;

namespace UE4.AnimGraph {
    ///<summary>This class is the schema for transition rule graphs in animation state machines</summary>
    public unsafe partial class AnimationTransitionSchema : EdGraphSchema_K2  {
        static AnimationTransitionSchema() {
            StaticClass = Main.GetClass("AnimationTransitionSchema");
        }
        internal unsafe AnimationTransitionSchema_fields* AnimationTransitionSchema_ptr => (AnimationTransitionSchema_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator AnimationTransitionSchema(IntPtr p) => UObject.Make<AnimationTransitionSchema>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static AnimationTransitionSchema DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static AnimationTransitionSchema New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
