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
using UE4.UMG.Native;
using UE4.MovieScene;

namespace UE4.UMG {
    ///<summary>A transform section</summary>
    public unsafe partial class MovieScene2DTransformSection : MovieSceneSection  {
        ///<summary>Transform Mask</summary>
        public unsafe MovieScene2DTransformMask TransformMask {
            get {return MovieScene2DTransformSection_ptr->TransformMask;}
            set {MovieScene2DTransformSection_ptr->TransformMask = value;}
        }
        ///<summary>Translation curves</summary>
        public unsafe MovieSceneFloatChannel Translation {
            get {return MovieScene2DTransformSection_ptr->Translation;}
            set {MovieScene2DTransformSection_ptr->Translation = value;}
        }
        ///<summary>Rotation curve</summary>
        public unsafe MovieSceneFloatChannel Rotation {
            get {return MovieScene2DTransformSection_ptr->Rotation;}
            set {MovieScene2DTransformSection_ptr->Rotation = value;}
        }
        ///<summary>Scale curves</summary>
        public unsafe MovieSceneFloatChannel Scale {
            get {return MovieScene2DTransformSection_ptr->Scale;}
            set {MovieScene2DTransformSection_ptr->Scale = value;}
        }
        ///<summary>Shear curve</summary>
        public unsafe MovieSceneFloatChannel Shear {
            get {return MovieScene2DTransformSection_ptr->Shear;}
            set {MovieScene2DTransformSection_ptr->Shear = value;}
        }
        static MovieScene2DTransformSection() {
            StaticClass = Main.GetClass("MovieScene2DTransformSection");
        }
        internal unsafe MovieScene2DTransformSection_fields* MovieScene2DTransformSection_ptr => (MovieScene2DTransformSection_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator MovieScene2DTransformSection(IntPtr p) => UObject.Make<MovieScene2DTransformSection>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static MovieScene2DTransformSection DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static MovieScene2DTransformSection New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
