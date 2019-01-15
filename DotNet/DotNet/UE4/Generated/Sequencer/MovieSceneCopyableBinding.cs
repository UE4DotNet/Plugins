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
using UE4.Sequencer.Native;
using UE4.MovieScene;

namespace UE4.Sequencer {
    ///<summary>Movie Scene Copyable Binding</summary>
    public unsafe partial class MovieSceneCopyableBinding : UObject  {
        ///<summary>
        ///Spawnables need to know about their Object Template but we cannot rely on automatic serialization due to the object
        ///template belonging to the Movie Scene (it gets serialized as a reference).
        ///</summary>
        ///<remarks>
        ///Instead we manually serialize the object
        ///so that we can duplicate it into a new object (which is stored in this variable) but we don't want this exported with
        ///the rest of the text as it'll fall back to the same reference issue. Marking this as TextExportTransient solves this.
        ///</remarks>
        public unsafe UObject SpawnableObjectTemplate {
            get {return MovieSceneCopyableBinding_ptr->SpawnableObjectTemplate;}
            set {MovieSceneCopyableBinding_ptr->SpawnableObjectTemplate = value;}
        }
        ///<summary>Tracks are also owned by the owning Movie Sequence.</summary>
        ///<remarks>
        ///We manually copy the tracks out of a binding when we copy,
        ///because the binding stores them as a reference to a privately owned object. We store these copied tracks here,
        ///and then restore them upon paste to re-create the tracks with the correct owner.
        ///</remarks>
        public ObjectArrayField<MovieSceneTrack> Tracks{ get {
            if(Tracks_store == null) Tracks_store = new ObjectArrayField<MovieSceneTrack> (&MovieSceneCopyableBinding_ptr->Tracks);
            return Tracks_store;
        } }
        private ObjectArrayField<MovieSceneTrack> Tracks_store;

        ///<summary>Binding</summary>
        public unsafe MovieSceneBinding Binding {
            get {return MovieSceneCopyableBinding_ptr->Binding;}
            set {MovieSceneCopyableBinding_ptr->Binding = value;}
        }
        ///<summary>Spawnable</summary>
        public unsafe MovieSceneSpawnable Spawnable {
            get {return MovieSceneCopyableBinding_ptr->Spawnable;}
            set {MovieSceneCopyableBinding_ptr->Spawnable = value;}
        }
        ///<summary>Possessable</summary>
        public unsafe MovieScenePossessable Possessable {
            get {return MovieSceneCopyableBinding_ptr->Possessable;}
            set {MovieSceneCopyableBinding_ptr->Possessable = value;}
        }
        static MovieSceneCopyableBinding() {
            StaticClass = Main.GetClass("MovieSceneCopyableBinding");
        }
        internal unsafe MovieSceneCopyableBinding_fields* MovieSceneCopyableBinding_ptr => (MovieSceneCopyableBinding_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator MovieSceneCopyableBinding(IntPtr p) => UObject.Make<MovieSceneCopyableBinding>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static MovieSceneCopyableBinding DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static MovieSceneCopyableBinding New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
