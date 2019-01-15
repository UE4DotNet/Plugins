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
    ///<summary>Anim State Node</summary>
    public unsafe partial class AnimStateNode : AnimStateNodeBase  {
        ///<summary>The animation graph for this state</summary>
        public unsafe EdGraph BoundGraph {
            get {return AnimStateNode_ptr->BoundGraph;}
            set {AnimStateNode_ptr->BoundGraph = value;}
        }
        ///<summary>The type of the contents of this state</summary>
        public unsafe byte StateType {
            get {return AnimStateNode_ptr->StateType;}
            set {AnimStateNode_ptr->StateType = value;}
        }
        ///<summary>State Entered</summary>
        public unsafe AnimNotifyEvent StateEntered {
            get {return AnimStateNode_ptr->StateEntered;}
            set {AnimStateNode_ptr->StateEntered = value;}
        }
        ///<summary>State Left</summary>
        public unsafe AnimNotifyEvent StateLeft {
            get {return AnimStateNode_ptr->StateLeft;}
            set {AnimStateNode_ptr->StateLeft = value;}
        }
        ///<summary>State Fully Blended</summary>
        public unsafe AnimNotifyEvent StateFullyBlended {
            get {return AnimStateNode_ptr->StateFullyBlended;}
            set {AnimStateNode_ptr->StateFullyBlended = value;}
        }
        public bool bAlwaysResetOnEntry {
            get {return Main.GetGetBoolPropertyByName(this, "bAlwaysResetOnEntry"); }
            set {Main.SetGetBoolPropertyByName(this, "bAlwaysResetOnEntry", value); }
        }
        static AnimStateNode() {
            StaticClass = Main.GetClass("AnimStateNode");
        }
        internal unsafe AnimStateNode_fields* AnimStateNode_ptr => (AnimStateNode_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator AnimStateNode(IntPtr p) => UObject.Make<AnimStateNode>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static AnimStateNode DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static AnimStateNode New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
