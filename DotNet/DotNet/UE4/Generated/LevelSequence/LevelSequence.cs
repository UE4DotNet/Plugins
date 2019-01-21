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
using UE4.LevelSequence.Native;
using UE4.MovieScene;

namespace UE4.LevelSequence {
    ///<summary>Movie scene animation for Actors.</summary>
    public unsafe partial class LevelSequence : MovieSceneSequence  {
        ///<summary>Pointer to the movie scene that controls this animation.</summary>
        public unsafe UMovieScene UMovieScene {
            get {return LevelSequence_ptr->UMovieScene;}
            set {LevelSequence_ptr->UMovieScene = value;}
        }
        ///<summary>A pointer to the director blueprint that generates this sequence's DirectorClass.</summary>
        public unsafe UObject DirectorBlueprint {
            get {return LevelSequence_ptr->DirectorBlueprint;}
            set {LevelSequence_ptr->DirectorBlueprint = value;}
        }
        ///<summary>The class that is used to spawn this level sequence's director instance.</summary>
        ///<remarks>Director instances are allocated on-demand one per sequence during evaluation and are used by event tracks for triggering events.</remarks>
        public unsafe SubclassOf<UObject> DirectorClass {
            get {return LevelSequence_ptr->DirectorClass;}
            set {LevelSequence_ptr->DirectorClass = value;}
        }
        ///<summary>Legacy object references - should be read-only. Not deprecated because they need to still be saved</summary>
        public unsafe LevelSequenceObjectReferenceMap ObjectReferences {
            get {return LevelSequence_ptr->ObjectReferences;}
            set {LevelSequence_ptr->ObjectReferences = value;}
        }
        ///<summary>References to bound objects.</summary>
        public unsafe LevelSequenceBindingReferences BindingReferences {
            get {return LevelSequence_ptr->BindingReferences;}
            set {LevelSequence_ptr->BindingReferences = value;}
        }
        static LevelSequence() {
            StaticClass = Main.GetClass("LevelSequence");
        }
        internal unsafe LevelSequence_fields* LevelSequence_ptr => (LevelSequence_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator LevelSequence(IntPtr p) => UObject.Make<LevelSequence>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static LevelSequence DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static LevelSequence New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
