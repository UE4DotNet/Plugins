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

namespace UE4.MovieSceneTools {
    ///<summary>Movie Scene User Import FBXSettings</summary>
    public unsafe partial class MovieSceneUserImportFBXSettings : UObject  {
        public bool bMatchByNameOnly {
            get {return Main.GetGetBoolPropertyByName(this, "bMatchByNameOnly"); }
            set {Main.SetGetBoolPropertyByName(this, "bMatchByNameOnly", value); }
        }
        public bool bForceFrontXAxis {
            get {return Main.GetGetBoolPropertyByName(this, "bForceFrontXAxis"); }
            set {Main.SetGetBoolPropertyByName(this, "bForceFrontXAxis", value); }
        }
        public bool bCreateCameras {
            get {return Main.GetGetBoolPropertyByName(this, "bCreateCameras"); }
            set {Main.SetGetBoolPropertyByName(this, "bCreateCameras", value); }
        }
        public bool bReduceKeys {
            get {return Main.GetGetBoolPropertyByName(this, "bReduceKeys"); }
            set {Main.SetGetBoolPropertyByName(this, "bReduceKeys", value); }
        }
        ///<summary>The tolerance for reduce keys</summary>
        public unsafe float ReduceKeysTolerance {
            get {return MovieSceneUserImportFBXSettings_ptr->ReduceKeysTolerance;}
            set {MovieSceneUserImportFBXSettings_ptr->ReduceKeysTolerance = value;}
        }
        static MovieSceneUserImportFBXSettings() {
            StaticClass = Main.GetClass("MovieSceneUserImportFBXSettings");
        }
        internal unsafe MovieSceneUserImportFBXSettings_fields* MovieSceneUserImportFBXSettings_ptr => (MovieSceneUserImportFBXSettings_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator MovieSceneUserImportFBXSettings(IntPtr p) => UObject.Make<MovieSceneUserImportFBXSettings>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static MovieSceneUserImportFBXSettings DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static MovieSceneUserImportFBXSettings New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
