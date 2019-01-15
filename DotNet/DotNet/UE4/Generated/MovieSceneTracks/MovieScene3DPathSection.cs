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
    ///<summary>A 3D Path section</summary>
    public unsafe partial class MovieScene3DPathSection : MovieScene3DConstraintSection  {
        ///<summary>Timing Curve</summary>
        public unsafe MovieSceneFloatChannel TimingCurve {
            get {return MovieScene3DPathSection_ptr->TimingCurve;}
            set {MovieScene3DPathSection_ptr->TimingCurve = value;}
        }
         //TODO: enum MovieScene3DPathSection_Axis FrontAxisEnum
         //TODO: enum MovieScene3DPathSection_Axis UpAxisEnum
        public bool bFollow {
            get {return Main.GetGetBoolPropertyByName(this, "bFollow"); }
            set {Main.SetGetBoolPropertyByName(this, "bFollow", value); }
        }
        public bool bReverse {
            get {return Main.GetGetBoolPropertyByName(this, "bReverse"); }
            set {Main.SetGetBoolPropertyByName(this, "bReverse", value); }
        }
        public bool bForceUpright {
            get {return Main.GetGetBoolPropertyByName(this, "bForceUpright"); }
            set {Main.SetGetBoolPropertyByName(this, "bForceUpright", value); }
        }
        static MovieScene3DPathSection() {
            StaticClass = Main.GetClass("MovieScene3DPathSection");
        }
        internal unsafe MovieScene3DPathSection_fields* MovieScene3DPathSection_ptr => (MovieScene3DPathSection_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator MovieScene3DPathSection(IntPtr p) => UObject.Make<MovieScene3DPathSection>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static MovieScene3DPathSection DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static MovieScene3DPathSection New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
