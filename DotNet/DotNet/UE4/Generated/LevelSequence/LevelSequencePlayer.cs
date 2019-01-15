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
    ///<summary>ULevelSequencePlayer is used to actually "play" an level sequence asset at runtime.</summary>
    ///<remarks>
    ///This class keeps track of playback state and provides functions for manipulating
    ///an level sequence while its playing.
    ///</remarks>
    public unsafe partial class LevelSequencePlayer : MovieSceneSequencePlayer  {

        ///<summary>Create a new level sequence player.</summary>
        ///<remarks>
        ///@param WorldContextObject Context object from which to retrieve a UWorld.
        ///@param LevelSequence The level sequence to play.
        ///@param Settings The desired playback settings
        ///@param OutActor The level sequence actor created to play this sequence.
        ///</remarks>
        public static (LevelSequenceActor, LevelSequencePlayer) CreateLevelSequencePlayer(UObject WorldContextObject, LevelSequence LevelSequence, MovieSceneSequencePlaybackSettings Settings)  => 
            LevelSequencePlayer_methods.CreateLevelSequencePlayer_method.Invoke(WorldContextObject, LevelSequence, Settings);
         //TODO: multicast delegate FOnLevelSequencePlayerCameraCutEvent OnCameraCut
        ///<summary>Array of additional event receivers</summary>
        public ObjectArrayField<UObject> AdditionalEventReceivers{ get {
            if(AdditionalEventReceivers_store == null) AdditionalEventReceivers_store = new ObjectArrayField<UObject> (&LevelSequencePlayer_ptr->AdditionalEventReceivers);
            return AdditionalEventReceivers_store;
        } }
        private ObjectArrayField<UObject> AdditionalEventReceivers_store;

        static LevelSequencePlayer() {
            StaticClass = Main.GetClass("LevelSequencePlayer");
        }
        internal unsafe LevelSequencePlayer_fields* LevelSequencePlayer_ptr => (LevelSequencePlayer_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator LevelSequencePlayer(IntPtr p) => UObject.Make<LevelSequencePlayer>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static LevelSequencePlayer DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static LevelSequencePlayer New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
