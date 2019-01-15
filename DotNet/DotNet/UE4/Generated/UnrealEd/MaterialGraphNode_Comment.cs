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
    ///<summary>Material Graph Node Comment</summary>
    public unsafe partial class MaterialGraphNode_Comment : EdGraphNode_Comment  {
        ///<summary>Material Comment that this node represents</summary>
        public unsafe MaterialExpressionComment MaterialExpressionComment {
            get {return MaterialGraphNode_Comment_ptr->MaterialExpressionComment;}
            set {MaterialGraphNode_Comment_ptr->MaterialExpressionComment = value;}
        }
        static MaterialGraphNode_Comment() {
            StaticClass = Main.GetClass("MaterialGraphNode_Comment");
        }
        internal unsafe MaterialGraphNode_Comment_fields* MaterialGraphNode_Comment_ptr => (MaterialGraphNode_Comment_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator MaterialGraphNode_Comment(IntPtr p) => UObject.Make<MaterialGraphNode_Comment>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static MaterialGraphNode_Comment DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static MaterialGraphNode_Comment New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
