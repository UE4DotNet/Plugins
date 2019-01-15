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
    ///<summary>Movie Scene Signed Object</summary>
    public unsafe partial class MovieSceneSignedObject : UObject  {
        ///<summary>Unique generation signature</summary>
        public unsafe FGuid Signature {
            get {return MovieSceneSignedObject_ptr->Signature;}
            set {MovieSceneSignedObject_ptr->Signature = value;}
        }
        static MovieSceneSignedObject() {
            StaticClass = Main.GetClass("MovieSceneSignedObject");
        }
        internal unsafe MovieSceneSignedObject_fields* MovieSceneSignedObject_ptr => (MovieSceneSignedObject_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator MovieSceneSignedObject(IntPtr p) => UObject.Make<MovieSceneSignedObject>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static MovieSceneSignedObject DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static MovieSceneSignedObject New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
