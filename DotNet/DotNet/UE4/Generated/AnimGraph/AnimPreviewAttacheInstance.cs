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
using UE4.AnimGraphRuntime;

namespace UE4.AnimGraph {
    ///<summary>This Instance only contains one AnimationAsset, and produce poses</summary>
    ///<remarks>Used by Preview in AnimGraph, Playing single animation in Kismet2 and etc</remarks>
    public unsafe partial class AnimPreviewAttacheInstance : AnimCustomInstance  {
        static AnimPreviewAttacheInstance() {
            StaticClass = Main.GetClass("AnimPreviewAttacheInstance");
        }
        internal unsafe AnimPreviewAttacheInstance_fields* AnimPreviewAttacheInstance_ptr => (AnimPreviewAttacheInstance_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator AnimPreviewAttacheInstance(IntPtr p) => UObject.Make<AnimPreviewAttacheInstance>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static AnimPreviewAttacheInstance DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static AnimPreviewAttacheInstance New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
