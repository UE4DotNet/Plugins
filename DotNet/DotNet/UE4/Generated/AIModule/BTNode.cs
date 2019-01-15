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
using UE4.AIModule.Native;

namespace UE4.AIModule {
    ///<summary>BTNode</summary>
    public unsafe partial class BTNode : UObject  {
         //TODO: string FString NodeName
        ///<summary>source asset</summary>
        public unsafe BehaviorTree TreeAsset {
            get {return BTNode_ptr->TreeAsset;}
            set {BTNode_ptr->TreeAsset = value;}
        }
        ///<summary>parent node</summary>
        public unsafe BTCompositeNode ParentNode {
            get {return BTNode_ptr->ParentNode;}
            set {BTNode_ptr->ParentNode = value;}
        }
        static BTNode() {
            StaticClass = Main.GetClass("BTNode");
        }
        internal unsafe BTNode_fields* BTNode_ptr => (BTNode_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator BTNode(IntPtr p) => UObject.Make<BTNode>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static BTNode DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static BTNode New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
