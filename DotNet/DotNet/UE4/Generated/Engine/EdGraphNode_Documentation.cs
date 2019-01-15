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
using UE4.Engine.Native;

namespace UE4.Engine {
    ///<summary>Ed Graph Node Documentation</summary>
    public unsafe partial class EdGraphNode_Documentation : EdGraphNode  {
         //TODO: string FString Link
         //TODO: string FString Excerpt
        static EdGraphNode_Documentation() {
            StaticClass = Main.GetClass("EdGraphNode_Documentation");
        }
        internal unsafe EdGraphNode_Documentation_fields* EdGraphNode_Documentation_ptr => (EdGraphNode_Documentation_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator EdGraphNode_Documentation(IntPtr p) => UObject.Make<EdGraphNode_Documentation>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static EdGraphNode_Documentation DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static EdGraphNode_Documentation New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
