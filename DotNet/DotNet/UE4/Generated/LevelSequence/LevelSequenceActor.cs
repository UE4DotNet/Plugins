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
using UE4.Engine;

namespace UE4.LevelSequence {
    ///<summary>Actor responsible for controlling a specific level sequence in the world.</summary>
    public unsafe partial class LevelSequenceActor : Actor  {

        ///<summary>Adds the specified actor to the overridden bindings for the specified binding ID, optionally still allowing the bindings defined in the Level Sequence asset</summary>
        public void AddBinding(MovieSceneObjectBindingID Binding, Actor Actor, bool bAllowBindingsFromAsset)  => 
            LevelSequenceActor_methods.AddBinding_method.Invoke(ObjPointer, Binding, Actor, bAllowBindingsFromAsset);

        ///<summary>Get the level sequence being played by this actor.</summary>
        ///<remarks>
        ///@param bLoad Whether to load the sequence object if it is not already in memory.
        ///@param bInitializePlayer Whether to initialize the player when the sequence has been loaded.
        ///@return Level sequence, or nullptr if not assigned or if it cannot be loaded.
        ///@see SetSequence
        ///</remarks>
        public LevelSequence GetSequence(bool bLoad, bool bInitializePlayer)  => 
            LevelSequenceActor_methods.GetSequence_method.Invoke(ObjPointer, bLoad, bInitializePlayer);

        ///<summary>Removes the specified actor from the specified binding's actor array</summary>
        public void RemoveBinding(MovieSceneObjectBindingID Binding, Actor Actor)  => 
            LevelSequenceActor_methods.RemoveBinding_method.Invoke(ObjPointer, Binding, Actor);

        ///<summary>Resets the specified binding back to the defaults defined by the Level Sequence asset</summary>
        public void ResetBinding(MovieSceneObjectBindingID Binding)  => 
            LevelSequenceActor_methods.ResetBinding_method.Invoke(ObjPointer, Binding);

        ///<summary>Resets all overridden bindings back to the defaults defined by the Level Sequence asset</summary>
        public void ResetBindings()  => 
            LevelSequenceActor_methods.ResetBindings_method.Invoke(ObjPointer);

        ///<summary>Overrides the specified binding with the specified actors, optionally still allowing the bindings defined in the Level Sequence asset</summary>
        public void SetBinding(MovieSceneObjectBindingID Binding, byte Actors /*TODO: array TArray */, bool bAllowBindingsFromAsset)  => 
            LevelSequenceActor_methods.SetBinding_method.Invoke(ObjPointer, Binding, Actors, bAllowBindingsFromAsset);

        ///<summary>
        ///Set an array of additional actors that will receive events triggerd from this sequence actor
        ///@
        ///</summary>
        ///<remarks>param AdditionalReceivers An array of actors to receive events</remarks>
        public void SetEventReceivers(byte AdditionalReceivers /*TODO: array TArray */)  => 
            LevelSequenceActor_methods.SetEventReceivers_method.Invoke(ObjPointer, AdditionalReceivers);

        ///<summary>Set the level sequence being played by this actor.</summary>
        ///<remarks>
        ///@param InSequence The sequence object to set.
        ///@see GetSequence
        ///</remarks>
        public void SetSequence(LevelSequence InSequence)  => 
            LevelSequenceActor_methods.SetSequence_method.Invoke(ObjPointer, InSequence);
        public bool bAutoPlay {
            get {return Main.GetGetBoolPropertyByName(this, "bAutoPlay"); }
        }
        ///<summary>Playback Settings</summary>
        public unsafe MovieSceneSequencePlaybackSettings PlaybackSettings {
            get {return LevelSequenceActor_ptr->PlaybackSettings;}
        }
        ///<summary>Sequence Player</summary>
        public unsafe LevelSequencePlayer SequencePlayer {
            get {return LevelSequenceActor_ptr->SequencePlayer;}
        }
        ///<summary>Level Sequence</summary>
        public unsafe SoftObjectPath LevelSequence {
            get {return LevelSequenceActor_ptr->LevelSequence;}
        }
        ///<summary>Additional Event Receivers</summary>
        public ObjectArrayField<Actor> AdditionalEventReceivers{ get {
            if(AdditionalEventReceivers_store == null) AdditionalEventReceivers_store = new ObjectArrayField<Actor> (&LevelSequenceActor_ptr->AdditionalEventReceivers);
            return AdditionalEventReceivers_store;
        } }
        private ObjectArrayField<Actor> AdditionalEventReceivers_store;

        ///<summary>Burn in Options</summary>
        public unsafe LevelSequenceBurnInOptions BurnInOptions {
            get {return LevelSequenceActor_ptr->BurnInOptions;}
        }
        ///<summary>Mapping of actors to override the sequence bindings with</summary>
        public unsafe MovieSceneBindingOverrides BindingOverrides {
            get {return LevelSequenceActor_ptr->BindingOverrides;}
        }
        public bool bOverrideInstanceData {
            get {return Main.GetGetBoolPropertyByName(this, "bOverrideInstanceData"); }
        }
        ///<summary>Instance data that can be used to dynamically control sequence evaluation at runtime</summary>
        public unsafe UObject DefaultInstanceData {
            get {return LevelSequenceActor_ptr->DefaultInstanceData;}
            set {LevelSequenceActor_ptr->DefaultInstanceData = value;}
        }
        ///<summary>Burn-in widget</summary>
        public unsafe LevelSequenceBurnIn BurnInInstance {
            get {return LevelSequenceActor_ptr->BurnInInstance;}
            set {LevelSequenceActor_ptr->BurnInInstance = value;}
        }
        static LevelSequenceActor() {
            StaticClass = Main.GetClass("LevelSequenceActor");
        }
        internal unsafe LevelSequenceActor_fields* LevelSequenceActor_ptr => (LevelSequenceActor_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator LevelSequenceActor(IntPtr p) => UObject.Make<LevelSequenceActor>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static LevelSequenceActor DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static LevelSequenceActor New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
