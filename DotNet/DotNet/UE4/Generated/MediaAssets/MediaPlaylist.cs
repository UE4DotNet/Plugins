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
using UE4.MediaAssets.Native;

namespace UE4.MediaAssets {
    ///<summary>Implements a media play list.</summary>
    public unsafe partial class MediaPlaylist : UObject  {

        ///<summary>Add a media source to the play list.</summary>
        ///<remarks>
        ///@param MediaSource The media source to append.
        ///@return true if the media source was added, false otherwise.
        ///@see AddFile, AddUrl, Insert, RemoveAll, Remove, Replace
        ///</remarks>
        public bool Add(MediaSource MediaSource)  => 
            MediaPlaylist_methods.Add_method.Invoke(ObjPointer, MediaSource);

        ///<summary>Add a media file path to the play list.</summary>
        ///<remarks>
        ///@param FilePath The file path to add.
        ///@return true if the file was added, false otherwise.
        ///@see Add, AddUrl, Insert, RemoveAll, Remove, Replace
        ///</remarks>
        public bool AddFile(string FilePath)  => 
            MediaPlaylist_methods.AddFile_method.Invoke(ObjPointer, FilePath);

        ///<summary>Add a media URL to the play list.</summary>
        ///<remarks>
        ///@param Url The URL to add.
        ///@return true if the URL was added, false otherwise.
        ///@see Add, AddFile, Insert, RemoveAll, Remove, Replace
        ///</remarks>
        public bool AddUrl(string Url)  => 
            MediaPlaylist_methods.AddUrl_method.Invoke(ObjPointer, Url);

        ///<summary>Get the media source at the specified index.</summary>
        ///<remarks>
        ///@param Index The index of the media source to get.
        ///@return The media source, or nullptr if the index doesn't exist.
        ///@see GetNext, GetRandom
        ///</remarks>
        public MediaSource Get(int Index)  => 
            MediaPlaylist_methods.Get_method.Invoke(ObjPointer, Index);

        ///<summary>Get the next media source in the play list.</summary>
        ///<remarks>
        ///@param InOutIndex Index of the current media source (will contain the new index).
        ///@return The media source after the current one, or nullptr if the list is empty.
        ///@see , GetPrevious, GetRandom
        ///</remarks>
        public (int, MediaSource) GetNext()  => 
            MediaPlaylist_methods.GetNext_method.Invoke(ObjPointer);

        ///<summary>Get the previous media source in the play list.</summary>
        ///<remarks>
        ///@param InOutIndex Index of the current media source (will contain the new index).
        ///@return The media source before the current one, or nullptr if the list is empty.
        ///@see , GetNext, GetRandom
        ///</remarks>
        public (int, MediaSource) GetPrevious()  => 
            MediaPlaylist_methods.GetPrevious_method.Invoke(ObjPointer);

        ///<summary>Get a random media source in the play list.</summary>
        ///<remarks>
        ///@param OutIndex Will contain the index of the returned media source.
        ///@return The random media source, or nullptr if the list is empty.
        ///@see Get, GetNext, GetPrevious
        ///</remarks>
        public (int, MediaSource) GetRandom()  => 
            MediaPlaylist_methods.GetRandom_method.Invoke(ObjPointer);

        ///<summary>Insert a media source into the play list at the given position.</summary>
        ///<remarks>
        ///@param MediaSource The media source to insert.
        ///@param Index The index to insert into.
        ///@see Add, Remove, RemoveAll, Replace
        ///</remarks>
        public void Insert(MediaSource MediaSource, int Index)  => 
            MediaPlaylist_methods.Insert_method.Invoke(ObjPointer, MediaSource, Index);

        ///<summary>Get the number of media sources in the play list.</summary>
        ///<remarks>
        ///@return Number of media sources.
        ///</remarks>
        public int Num()  => 
            MediaPlaylist_methods.Num_method.Invoke(ObjPointer);

        ///<summary>Remove all occurrences of the given media source in the play list.</summary>
        ///<remarks>
        ///@param MediaSource The media source to remove.
        ///@return true if the media source was removed, false otherwise.
        ///@see Add, Insert, Remove, Replace
        ///</remarks>
        public bool Remove(MediaSource MediaSource)  => 
            MediaPlaylist_methods.Remove_method.Invoke(ObjPointer, MediaSource);

        ///<summary>Remove the media source at the specified position.</summary>
        ///<remarks>
        ///@param Index The index of the media source to remove.
        ///@return true if the media source was removed, false otherwise.
        ///@see Add, Insert, RemoveAll, Replace
        ///</remarks>
        public bool RemoveAt(int Index)  => 
            MediaPlaylist_methods.RemoveAt_method.Invoke(ObjPointer, Index);

        ///<summary>Replace the media source at the specified position.</summary>
        ///<remarks>
        ///@param Index The index of the media source to replace.
        ///@param Replacement The replacement media source.
        ///@return true if the media source was replaced, false otherwise.
        ///@see Add, Insert, RemoveAll, RemoveAt
        ///</remarks>
        public bool Replace(int Index, MediaSource Replacement)  => 
            MediaPlaylist_methods.Replace_method.Invoke(ObjPointer, Index, Replacement);
        ///<summary>List of media sources to play.</summary>
        public ObjectArrayField<MediaSource> Items{ get {
            if(Items_store == null) Items_store = new ObjectArrayField<MediaSource> (&MediaPlaylist_ptr->Items);
            return Items_store;
        } }
        private ObjectArrayField<MediaSource> Items_store;

        static MediaPlaylist() {
            StaticClass = Main.GetClass("MediaPlaylist");
        }
        internal unsafe MediaPlaylist_fields* MediaPlaylist_ptr => (MediaPlaylist_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator MediaPlaylist(IntPtr p) => UObject.Make<MediaPlaylist>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static MediaPlaylist DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static MediaPlaylist New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
