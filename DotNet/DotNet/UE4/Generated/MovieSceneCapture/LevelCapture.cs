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
using UE4.MovieSceneCapture.Native;

namespace UE4.MovieSceneCapture {
    ///<summary>Level Capture</summary>
    public unsafe partial class LevelCapture : UE4.MovieSceneCapture.MovieSceneCapture  {
        public bool bAutoStartCapture {
            get {return Main.GetGetBoolPropertyByName(this, "bAutoStartCapture"); }
            set {Main.SetGetBoolPropertyByName(this, "bAutoStartCapture", value); }
        }
        ///<summary>Copy of the ID from PrerequisiteActor. Required because JSON serialization exports the path of the object, rather that its GUID</summary>
        public unsafe FGuid PrerequisiteActorId {
            get {return LevelCapture_ptr->PrerequisiteActorId;}
            set {LevelCapture_ptr->PrerequisiteActorId = value;}
        }
        static LevelCapture() {
            StaticClass = Main.GetClass("LevelCapture");
        }
        internal unsafe LevelCapture_fields* LevelCapture_ptr => (LevelCapture_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator LevelCapture(IntPtr p) => UObject.Make<LevelCapture>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static LevelCapture DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static LevelCapture New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
