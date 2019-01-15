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
    ///<summary>K2Node Transition Rule Getter</summary>
    public unsafe partial class K2Node_TransitionRuleGetter : K2Node  {
        ///<summary>Getter Type</summary>
        public unsafe byte GetterType {
            get {return K2Node_TransitionRuleGetter_ptr->GetterType;}
            set {K2Node_TransitionRuleGetter_ptr->GetterType = value;}
        }
        ///<summary>Associated Anim Asset Player Node</summary>
        public unsafe AnimGraphNode_Base AssociatedAnimAssetPlayerNode {
            get {return K2Node_TransitionRuleGetter_ptr->AssociatedAnimAssetPlayerNode;}
            set {K2Node_TransitionRuleGetter_ptr->AssociatedAnimAssetPlayerNode = value;}
        }
        ///<summary>Associated State Node</summary>
        public unsafe AnimStateNode AssociatedStateNode {
            get {return K2Node_TransitionRuleGetter_ptr->AssociatedStateNode;}
            set {K2Node_TransitionRuleGetter_ptr->AssociatedStateNode = value;}
        }
        static K2Node_TransitionRuleGetter() {
            StaticClass = Main.GetClass("K2Node_TransitionRuleGetter");
        }
        internal unsafe K2Node_TransitionRuleGetter_fields* K2Node_TransitionRuleGetter_ptr => (K2Node_TransitionRuleGetter_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator K2Node_TransitionRuleGetter(IntPtr p) => UObject.Make<K2Node_TransitionRuleGetter>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static K2Node_TransitionRuleGetter DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static K2Node_TransitionRuleGetter New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
