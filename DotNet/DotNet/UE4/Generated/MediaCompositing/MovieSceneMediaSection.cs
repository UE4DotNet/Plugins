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
using UE4.MediaCompositing.Native;
using UE4.MovieScene;
using UE4.MediaAssets;

namespace UE4.MediaCompositing {
    ///<summary>Implements a movie scene section for media playback.</summary>
    public unsafe partial class MovieSceneMediaSection : MovieSceneSection  {
        ///<summary>The source to play with this video track.</summary>
        public unsafe MediaSource MediaSource {
            get {return MovieSceneMediaSection_ptr->MediaSource;}
            set {MovieSceneMediaSection_ptr->MediaSource = value;}
        }
        public bool bLooping {
            get {return Main.GetGetBoolPropertyByName(this, "bLooping"); }
            set {Main.SetGetBoolPropertyByName(this, "bLooping", value); }
        }
        ///<summary>The media texture that receives the track's video output.</summary>
        public unsafe MediaTexture MediaTexture {
            get {return MovieSceneMediaSection_ptr->MediaTexture;}
            set {MovieSceneMediaSection_ptr->MediaTexture = value;}
        }
        ///<summary>The media sound component that receives the track's audio output.</summary>
        public unsafe MediaSoundComponent MediaSoundComponent {
            get {return MovieSceneMediaSection_ptr->MediaSoundComponent;}
            set {MovieSceneMediaSection_ptr->MediaSoundComponent = value;}
        }
        public bool bUseExternalMediaPlayer {
            get {return Main.GetGetBoolPropertyByName(this, "bUseExternalMediaPlayer"); }
            set {Main.SetGetBoolPropertyByName(this, "bUseExternalMediaPlayer", value); }
        }
        ///<summary>The external media player this track should control.</summary>
        public unsafe MediaPlayer ExternalMediaPlayer {
            get {return MovieSceneMediaSection_ptr->ExternalMediaPlayer;}
            set {MovieSceneMediaSection_ptr->ExternalMediaPlayer = value;}
        }
        ///<summary>The reference frame offset for single thumbnail rendering</summary>
        public unsafe float ThumbnailReferenceOffset {
            get {return MovieSceneMediaSection_ptr->ThumbnailReferenceOffset;}
            set {MovieSceneMediaSection_ptr->ThumbnailReferenceOffset = value;}
        }
        static MovieSceneMediaSection() {
            StaticClass = Main.GetClass("MovieSceneMediaSection");
        }
        internal unsafe MovieSceneMediaSection_fields* MovieSceneMediaSection_ptr => (MovieSceneMediaSection_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator MovieSceneMediaSection(IntPtr p) => UObject.Make<MovieSceneMediaSection>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static MovieSceneMediaSection DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static MovieSceneMediaSection New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
