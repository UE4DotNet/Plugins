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
using UE4.BehaviorTreeEditor.Native;
using UE4.AIGraph;

namespace UE4.BehaviorTreeEditor {
    ///<summary>Behavior Tree Graph</summary>
    public unsafe partial class BehaviorTreeGraph : UE4.AIGraph.AIGraph  {
        ///<summary>increased with every graph rebuild, used to refresh data from subtrees</summary>
        public unsafe int ModCounter {
            get {return BehaviorTreeGraph_ptr->ModCounter;}
            set {BehaviorTreeGraph_ptr->ModCounter = value;}
        }
        public bool bIsUsingModCounter {
            get {return Main.GetGetBoolPropertyByName(this, "bIsUsingModCounter"); }
            set {Main.SetGetBoolPropertyByName(this, "bIsUsingModCounter", value); }
        }
        static BehaviorTreeGraph() {
            StaticClass = Main.GetClass("BehaviorTreeGraph");
        }
        internal unsafe BehaviorTreeGraph_fields* BehaviorTreeGraph_ptr => (BehaviorTreeGraph_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator BehaviorTreeGraph(IntPtr p) => UObject.Make<BehaviorTreeGraph>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static BehaviorTreeGraph DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static BehaviorTreeGraph New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
