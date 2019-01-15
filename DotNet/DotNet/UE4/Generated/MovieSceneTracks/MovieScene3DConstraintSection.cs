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
using UE4.MovieSceneTracks.Native;
using UE4.MovieScene;

namespace UE4.MovieSceneTracks {
    ///<summary>Base class for 3D constraint section</summary>
    public unsafe partial class MovieScene3DConstraintSection : MovieSceneSection  {
        ///<summary>The constraint binding that this movie Constraint uses</summary>
        public unsafe MovieSceneObjectBindingID ConstraintBindingID {
            get {return MovieScene3DConstraintSection_ptr->ConstraintBindingID;}
            set {MovieScene3DConstraintSection_ptr->ConstraintBindingID = value;}
        }
        static MovieScene3DConstraintSection() {
            StaticClass = Main.GetClass("MovieScene3DConstraintSection");
        }
        internal unsafe MovieScene3DConstraintSection_fields* MovieScene3DConstraintSection_ptr => (MovieScene3DConstraintSection_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator MovieScene3DConstraintSection(IntPtr p) => UObject.Make<MovieScene3DConstraintSection>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static MovieScene3DConstraintSection DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static MovieScene3DConstraintSection New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
