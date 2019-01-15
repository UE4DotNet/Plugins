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
using UE4.MovieScene.Native;

namespace UE4.MovieScene {
    ///<summary>A one-to-many definition of movie scene object binding IDs to overridden objects that should be bound to that binding.</summary>
    public unsafe partial class MovieSceneBindingOverrides : UObject  {
         //TODO: array not UObject TArray BindingData
        static MovieSceneBindingOverrides() {
            StaticClass = Main.GetClass("MovieSceneBindingOverrides");
        }
        internal unsafe MovieSceneBindingOverrides_fields* MovieSceneBindingOverrides_ptr => (MovieSceneBindingOverrides_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator MovieSceneBindingOverrides(IntPtr p) => UObject.Make<MovieSceneBindingOverrides>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static MovieSceneBindingOverrides DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static MovieSceneBindingOverrides New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
