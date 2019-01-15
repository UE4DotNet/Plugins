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
    ///<summary>
    ///This is the base class for any animation graph nodes that generate or consume an animation pose in
    ///the animation blend graph.
    ///</summary>
    ///<remarks>Any concrete implementations will be paired with a runtime graph node derived from FAnimNode_Base</remarks>
    public unsafe partial class AnimGraphNode_Base : K2Node  {
         //TODO: array not UObject TArray ShowPinForProperties
         //TODO: enum EBlueprintUsage BlueprintUsage
        static AnimGraphNode_Base() {
            StaticClass = Main.GetClass("AnimGraphNode_Base");
        }
        internal unsafe AnimGraphNode_Base_fields* AnimGraphNode_Base_ptr => (AnimGraphNode_Base_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator AnimGraphNode_Base(IntPtr p) => UObject.Make<AnimGraphNode_Base>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static AnimGraphNode_Base DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static AnimGraphNode_Base New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
