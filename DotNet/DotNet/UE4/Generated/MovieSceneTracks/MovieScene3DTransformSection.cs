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
    ///<summary>A 3D transform section</summary>
    public unsafe partial class MovieScene3DTransformSection : MovieSceneSection  {
        ///<summary>Transform Mask</summary>
        public unsafe MovieSceneTransformMask TransformMask {
            get {return MovieScene3DTransformSection_ptr->TransformMask;}
            set {MovieScene3DTransformSection_ptr->TransformMask = value;}
        }
        ///<summary>Translation curves</summary>
        public unsafe MovieSceneFloatChannel Translation {
            get {return MovieScene3DTransformSection_ptr->Translation;}
            set {MovieScene3DTransformSection_ptr->Translation = value;}
        }
        ///<summary>Rotation curves</summary>
        public unsafe MovieSceneFloatChannel Rotation {
            get {return MovieScene3DTransformSection_ptr->Rotation;}
            set {MovieScene3DTransformSection_ptr->Rotation = value;}
        }
        ///<summary>Scale curves</summary>
        public unsafe MovieSceneFloatChannel Scale {
            get {return MovieScene3DTransformSection_ptr->Scale;}
            set {MovieScene3DTransformSection_ptr->Scale = value;}
        }
        ///<summary>Manual weight curve</summary>
        public unsafe MovieSceneFloatChannel ManualWeight {
            get {return MovieScene3DTransformSection_ptr->ManualWeight;}
            set {MovieScene3DTransformSection_ptr->ManualWeight = value;}
        }
        public bool bUseQuaternionInterpolation {
            get {return Main.GetGetBoolPropertyByName(this, "bUseQuaternionInterpolation"); }
            set {Main.SetGetBoolPropertyByName(this, "bUseQuaternionInterpolation", value); }
        }
         //TODO: enum EShow3DTrajectory Show3DTrajectory
        static MovieScene3DTransformSection() {
            StaticClass = Main.GetClass("MovieScene3DTransformSection");
        }
        internal unsafe MovieScene3DTransformSection_fields* MovieScene3DTransformSection_ptr => (MovieScene3DTransformSection_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator MovieScene3DTransformSection(IntPtr p) => UObject.Make<MovieScene3DTransformSection>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static MovieScene3DTransformSection DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static MovieScene3DTransformSection New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
