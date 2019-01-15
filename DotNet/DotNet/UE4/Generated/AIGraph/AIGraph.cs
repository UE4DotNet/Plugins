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
using UE4.AIGraph.Native;
using UE4.Engine;

namespace UE4.AIGraph {
    ///<summary>AIGraph</summary>
    public unsafe partial class AIGraph : EdGraph  {
        ///<summary>Graph Version</summary>
        public unsafe int GraphVersion {
            get {return AIGraph_ptr->GraphVersion;}
            set {AIGraph_ptr->GraphVersion = value;}
        }
        static AIGraph() {
            StaticClass = Main.GetClass("AIGraph");
        }
        internal unsafe AIGraph_fields* AIGraph_ptr => (AIGraph_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator AIGraph(IntPtr p) => UObject.Make<AIGraph>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static AIGraph DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static AIGraph New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
