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
using UE4.Engine;

namespace UE4.AnimGraph {
    ///<summary>K2Node Anim Getter</summary>
    public unsafe partial class K2Node_AnimGetter : K2Node_CallFunction  {
        ///<summary>The node that is required for the getter</summary>
        public unsafe AnimGraphNode_Base SourceNode {
            get {return K2Node_AnimGetter_ptr->SourceNode;}
            set {K2Node_AnimGetter_ptr->SourceNode = value;}
        }
        ///<summary>
        ///UAnimStateNode doesn't use the same hierarchy so we need to have a seperate property here to handle
        ///those.
        ///</summary>
        public unsafe AnimStateNodeBase SourceStateNode {
            get {return K2Node_AnimGetter_ptr->SourceStateNode;}
            set {K2Node_AnimGetter_ptr->SourceStateNode = value;}
        }
        ///<summary>The UAnimInstance derived class that implements the getter we are running</summary>
        public unsafe SubclassOf<UObject> GetterClass {
            get {return K2Node_AnimGetter_ptr->GetterClass;}
            set {K2Node_AnimGetter_ptr->GetterClass = value;}
        }
        ///<summary>The anim blueprint that generated this getter</summary>
        public unsafe AnimBlueprint SourceAnimBlueprint {
            get {return K2Node_AnimGetter_ptr->SourceAnimBlueprint;}
            set {K2Node_AnimGetter_ptr->SourceAnimBlueprint = value;}
        }
         //TODO: text FText CachedTitle
         //TODO: array not UObject TArray Contexts
        static K2Node_AnimGetter() {
            StaticClass = Main.GetClass("K2Node_AnimGetter");
        }
        internal unsafe K2Node_AnimGetter_fields* K2Node_AnimGetter_ptr => (K2Node_AnimGetter_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator K2Node_AnimGetter(IntPtr p) => UObject.Make<K2Node_AnimGetter>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static K2Node_AnimGetter DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static K2Node_AnimGetter New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
