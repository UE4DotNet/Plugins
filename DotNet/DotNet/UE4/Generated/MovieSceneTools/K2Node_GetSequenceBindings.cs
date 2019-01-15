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
using UE4.MovieSceneTools.Native;
using UE4.BlueprintGraph;
using UE4.MovieScene;

namespace UE4.MovieSceneTools {
    ///<summary>K2Node Get Sequence Bindings</summary>
    public unsafe partial class K2Node_GetSequenceBindings : K2Node  {
         //TODO: array not UObject TArray BindingGuids
        ///<summary>Sequence</summary>
        public unsafe MovieSceneSequence Sequence {
            get {return K2Node_GetSequenceBindings_ptr->Sequence;}
            set {K2Node_GetSequenceBindings_ptr->Sequence = value;}
        }
        static K2Node_GetSequenceBindings() {
            StaticClass = Main.GetClass("K2Node_GetSequenceBindings");
        }
        internal unsafe K2Node_GetSequenceBindings_fields* K2Node_GetSequenceBindings_ptr => (K2Node_GetSequenceBindings_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator K2Node_GetSequenceBindings(IntPtr p) => UObject.Make<K2Node_GetSequenceBindings>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static K2Node_GetSequenceBindings DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static K2Node_GetSequenceBindings New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
