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
using UE4.MovieScene;
using UE4.BlueprintGraph;

namespace UE4.MovieSceneTools {
    ///<summary>K2Node Get Sequence Binding</summary>
    public unsafe partial class K2Node_GetSequenceBinding : K2Node  {
        ///<summary>The sequence from which to choose a binding identifier</summary>
        public unsafe SoftObjectPath SourceSequence {
            get {return K2Node_GetSequenceBinding_ptr->SourceSequence;}
            set {K2Node_GetSequenceBinding_ptr->SourceSequence = value;}
        }
        ///<summary>The user-selected literal binding identifier from the sequence to use</summary>
        public unsafe MovieSceneObjectBindingID Binding {
            get {return K2Node_GetSequenceBinding_ptr->Binding;}
            set {K2Node_GetSequenceBinding_ptr->Binding = value;}
        }
        static K2Node_GetSequenceBinding() {
            StaticClass = Main.GetClass("K2Node_GetSequenceBinding");
        }
        internal unsafe K2Node_GetSequenceBinding_fields* K2Node_GetSequenceBinding_ptr => (K2Node_GetSequenceBinding_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator K2Node_GetSequenceBinding(IntPtr p) => UObject.Make<K2Node_GetSequenceBinding>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static K2Node_GetSequenceBinding DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static K2Node_GetSequenceBinding New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
