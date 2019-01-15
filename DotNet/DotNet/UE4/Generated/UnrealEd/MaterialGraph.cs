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
    ///<summary>Material Graph</summary>
    public unsafe partial class MaterialGraph : EdGraph  {
        ///<summary>Material this Graph represents</summary>
        public unsafe Material Material {
            get {return MaterialGraph_ptr->Material;}
            set {MaterialGraph_ptr->Material = value;}
        }
        ///<summary>Material Function this Graph represents (NULL for Materials)</summary>
        public unsafe MaterialFunction MaterialFunction {
            get {return MaterialGraph_ptr->MaterialFunction;}
            set {MaterialGraph_ptr->MaterialFunction = value;}
        }
        ///<summary>Root node representing Material inputs (NULL for Material Functions)</summary>
        public unsafe MaterialGraphNode_Root RootNode {
            get {return MaterialGraph_ptr->RootNode;}
            set {MaterialGraph_ptr->RootNode = value;}
        }
         //TODO: string FString OriginalMaterialFullName
        static MaterialGraph() {
            StaticClass = Main.GetClass("MaterialGraph");
        }
        internal unsafe MaterialGraph_fields* MaterialGraph_ptr => (MaterialGraph_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator MaterialGraph(IntPtr p) => UObject.Make<MaterialGraph>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static MaterialGraph DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static MaterialGraph New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
