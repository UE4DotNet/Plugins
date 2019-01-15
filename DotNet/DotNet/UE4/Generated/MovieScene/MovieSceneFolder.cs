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
    ///<summary>Represents a folder used for organizing objects in tracks in a movie scene.</summary>
    public unsafe partial class MovieSceneFolder : UObject  {
        ///<summary>The name of this folder.</summary>
        public unsafe Name FolderName {
            get {return MovieSceneFolder_ptr->FolderName;}
            set {MovieSceneFolder_ptr->FolderName = value;}
        }
        ///<summary>The folders contained by this folder.</summary>
        public ObjectArrayField<MovieSceneFolder> ChildFolders{ get {
            if(ChildFolders_store == null) ChildFolders_store = new ObjectArrayField<MovieSceneFolder> (&MovieSceneFolder_ptr->ChildFolders);
            return ChildFolders_store;
        } }
        private ObjectArrayField<MovieSceneFolder> ChildFolders_store;

        ///<summary>The master tracks contained by this folder.</summary>
        public ObjectArrayField<MovieSceneTrack> ChildMasterTracks{ get {
            if(ChildMasterTracks_store == null) ChildMasterTracks_store = new ObjectArrayField<MovieSceneTrack> (&MovieSceneFolder_ptr->ChildMasterTracks);
            return ChildMasterTracks_store;
        } }
        private ObjectArrayField<MovieSceneTrack> ChildMasterTracks_store;

         //TODO: array not UObject TArray ChildObjectBindingStrings
        ///<summary>This folder's color</summary>
        public unsafe Color FolderColor {
            get {return MovieSceneFolder_ptr->FolderColor;}
            set {MovieSceneFolder_ptr->FolderColor = value;}
        }
        ///<summary>This folder's desired sorting order</summary>
        public unsafe int SortingOrder {
            get {return MovieSceneFolder_ptr->SortingOrder;}
            set {MovieSceneFolder_ptr->SortingOrder = value;}
        }
        static MovieSceneFolder() {
            StaticClass = Main.GetClass("MovieSceneFolder");
        }
        internal unsafe MovieSceneFolder_fields* MovieSceneFolder_ptr => (MovieSceneFolder_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator MovieSceneFolder(IntPtr p) => UObject.Make<MovieSceneFolder>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static MovieSceneFolder DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static MovieSceneFolder New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
