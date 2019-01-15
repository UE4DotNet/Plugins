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
    ///<summary>Material Graph Node Root</summary>
    public unsafe partial class MaterialGraphNode_Root : MaterialGraphNode_Base  {
        ///<summary>Material whose inputs this root node represents</summary>
        public unsafe Material Material {
            get {return MaterialGraphNode_Root_ptr->Material;}
            set {MaterialGraphNode_Root_ptr->Material = value;}
        }
        static MaterialGraphNode_Root() {
            StaticClass = Main.GetClass("MaterialGraphNode_Root");
        }
        internal unsafe MaterialGraphNode_Root_fields* MaterialGraphNode_Root_ptr => (MaterialGraphNode_Root_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator MaterialGraphNode_Root(IntPtr p) => UObject.Make<MaterialGraphNode_Root>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static MaterialGraphNode_Root DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static MaterialGraphNode_Root New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
