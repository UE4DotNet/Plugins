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
using UE4.UnrealEd.Native;
using UE4.Engine;

namespace UE4.UnrealEd {
    ///<summary>Material Graph Node</summary>
    public unsafe partial class MaterialGraphNode : MaterialGraphNode_Base  {
        ///<summary>Material Expression this node is representing</summary>
        public unsafe MaterialExpression MaterialExpression {
            get {return MaterialGraphNode_ptr->MaterialExpression;}
            set {MaterialGraphNode_ptr->MaterialExpression = value;}
        }
        static MaterialGraphNode() {
            StaticClass = Main.GetClass("MaterialGraphNode");
        }
        internal unsafe MaterialGraphNode_fields* MaterialGraphNode_ptr => (MaterialGraphNode_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator MaterialGraphNode(IntPtr p) => UObject.Make<MaterialGraphNode>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static MaterialGraphNode DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static MaterialGraphNode New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
