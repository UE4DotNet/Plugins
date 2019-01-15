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
using UE4.BlueprintGraph.Native;
using UE4.Engine;

namespace UE4.BlueprintGraph {
    ///<summary>Ed Graph Schema K2</summary>
    public unsafe partial class EdGraphSchema_K2 : EdGraphSchema  {
         //TODO: array not UObject TArray EditoronlyBPFunctionRedirects
        static EdGraphSchema_K2() {
            StaticClass = Main.GetClass("EdGraphSchema_K2");
        }
        internal unsafe EdGraphSchema_K2_fields* EdGraphSchema_K2_ptr => (EdGraphSchema_K2_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator EdGraphSchema_K2(IntPtr p) => UObject.Make<EdGraphSchema_K2>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static EdGraphSchema_K2 DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static EdGraphSchema_K2 New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
