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
    ///<summary>@TODO: Should this derive from AnimationTransitionSchema (with appropriate suppression of state-based queries)</summary>
    public unsafe partial class AnimationConduitGraphSchema : EdGraphSchema_K2  {
        static AnimationConduitGraphSchema() {
            StaticClass = Main.GetClass("AnimationConduitGraphSchema");
        }
        internal unsafe AnimationConduitGraphSchema_fields* AnimationConduitGraphSchema_ptr => (AnimationConduitGraphSchema_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator AnimationConduitGraphSchema(IntPtr p) => UObject.Make<AnimationConduitGraphSchema>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static AnimationConduitGraphSchema DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static AnimationConduitGraphSchema New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
