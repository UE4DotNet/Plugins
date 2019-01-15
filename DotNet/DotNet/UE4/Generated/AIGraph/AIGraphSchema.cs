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
    ///<summary>AIGraph Schema</summary>
    public unsafe partial class AIGraphSchema : EdGraphSchema  {
        static AIGraphSchema() {
            StaticClass = Main.GetClass("AIGraphSchema");
        }
        internal unsafe AIGraphSchema_fields* AIGraphSchema_ptr => (AIGraphSchema_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator AIGraphSchema(IntPtr p) => UObject.Make<AIGraphSchema>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static AIGraphSchema DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static AIGraphSchema New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
