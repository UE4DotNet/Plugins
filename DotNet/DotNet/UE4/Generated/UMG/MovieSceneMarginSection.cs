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
    ///<summary>A section in a Margin track</summary>
    public unsafe partial class MovieSceneMarginSection : MovieSceneSection  {
        ///<summary>Red curve data</summary>
        public unsafe MovieSceneFloatChannel TopCurve {
            get {return MovieSceneMarginSection_ptr->TopCurve;}
            set {MovieSceneMarginSection_ptr->TopCurve = value;}
        }
        ///<summary>Green curve data</summary>
        public unsafe MovieSceneFloatChannel LeftCurve {
            get {return MovieSceneMarginSection_ptr->LeftCurve;}
            set {MovieSceneMarginSection_ptr->LeftCurve = value;}
        }
        ///<summary>Blue curve data</summary>
        public unsafe MovieSceneFloatChannel RightCurve {
            get {return MovieSceneMarginSection_ptr->RightCurve;}
            set {MovieSceneMarginSection_ptr->RightCurve = value;}
        }
        ///<summary>Alpha curve data</summary>
        public unsafe MovieSceneFloatChannel BottomCurve {
            get {return MovieSceneMarginSection_ptr->BottomCurve;}
            set {MovieSceneMarginSection_ptr->BottomCurve = value;}
        }
        static MovieSceneMarginSection() {
            StaticClass = Main.GetClass("MovieSceneMarginSection");
        }
        internal unsafe MovieSceneMarginSection_fields* MovieSceneMarginSection_ptr => (MovieSceneMarginSection_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator MovieSceneMarginSection(IntPtr p) => UObject.Make<MovieSceneMarginSection>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static MovieSceneMarginSection DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static MovieSceneMarginSection New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
