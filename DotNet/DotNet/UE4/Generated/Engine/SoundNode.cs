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
    ///<summary>Sound Node</summary>
    public unsafe partial class SoundNode : UObject  {
        ///<summary>Child Nodes</summary>
        public ObjectArrayField<SoundNode> ChildNodes{ get {
            if(ChildNodes_store == null) ChildNodes_store = new ObjectArrayField<SoundNode> (&SoundNode_ptr->ChildNodes);
            return ChildNodes_store;
        } }
        private ObjectArrayField<SoundNode> ChildNodes_store;

        ///<summary>Node's Graph representation, used to get position.</summary>
        public unsafe EdGraphNode GraphNode {
            get {return SoundNode_ptr->GraphNode;}
            set {SoundNode_ptr->GraphNode = value;}
        }
        static SoundNode() {
            StaticClass = Main.GetClass("SoundNode");
        }
        internal unsafe SoundNode_fields* SoundNode_ptr => (SoundNode_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator SoundNode(IntPtr p) => UObject.Make<SoundNode>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static SoundNode DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static SoundNode New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
