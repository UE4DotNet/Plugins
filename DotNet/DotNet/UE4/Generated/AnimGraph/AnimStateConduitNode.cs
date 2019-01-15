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
    ///<summary>Anim State Conduit Node</summary>
    public unsafe partial class AnimStateConduitNode : AnimStateNodeBase  {
        ///<summary>The transition graph for this conduit; it's a logic graph, not an animation graph</summary>
        public unsafe EdGraph BoundGraph {
            get {return AnimStateConduitNode_ptr->BoundGraph;}
            set {AnimStateConduitNode_ptr->BoundGraph = value;}
        }
        static AnimStateConduitNode() {
            StaticClass = Main.GetClass("AnimStateConduitNode");
        }
        internal unsafe AnimStateConduitNode_fields* AnimStateConduitNode_ptr => (AnimStateConduitNode_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator AnimStateConduitNode(IntPtr p) => UObject.Make<AnimStateConduitNode>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static AnimStateConduitNode DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static AnimStateConduitNode New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
