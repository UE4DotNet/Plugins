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
using UE4.Engine.Native;

namespace UE4.Engine {
    ///<summary>The behavior of audio playback is defined within Sound Cues.</summary>
    public unsafe partial class SoundCue : SoundBase  {
        public bool bOverrideAttenuation {
            get {return Main.GetGetBoolPropertyByName(this, "bOverrideAttenuation"); }
            set {Main.SetGetBoolPropertyByName(this, "bOverrideAttenuation", value); }
        }
        public bool bExcludeFromRandomNodeBranchCulling {
            get {return Main.GetGetBoolPropertyByName(this, "bExcludeFromRandomNodeBranchCulling"); }
            set {Main.SetGetBoolPropertyByName(this, "bExcludeFromRandomNodeBranchCulling", value); }
        }
        ///<summary>First Node</summary>
        public unsafe SoundNode FirstNode {
            get {return SoundCue_ptr->FirstNode;}
            set {SoundCue_ptr->FirstNode = value;}
        }
        ///<summary>Volume multiplier for the Sound Cue</summary>
        public unsafe float VolumeMultiplier {
            get {return SoundCue_ptr->VolumeMultiplier;}
            set {SoundCue_ptr->VolumeMultiplier = value;}
        }
        ///<summary>Pitch multiplier for the Sound Cue</summary>
        public unsafe float PitchMultiplier {
            get {return SoundCue_ptr->PitchMultiplier;}
            set {SoundCue_ptr->PitchMultiplier = value;}
        }
        ///<summary>Attenuation settings to use if Override Attenuation is set to true</summary>
        public unsafe SoundAttenuationSettings AttenuationOverrides {
            get {return SoundCue_ptr->AttenuationOverrides;}
            set {SoundCue_ptr->AttenuationOverrides = value;}
        }
        ///<summary>All Nodes</summary>
        public ObjectArrayField<SoundNode> AllNodes{ get {
            if(AllNodes_store == null) AllNodes_store = new ObjectArrayField<SoundNode> (&SoundCue_ptr->AllNodes);
            return AllNodes_store;
        } }
        private ObjectArrayField<SoundNode> AllNodes_store;

        ///<summary>Sound Cue Graph</summary>
        public unsafe EdGraph SoundCueGraph {
            get {return SoundCue_ptr->SoundCueGraph;}
            set {SoundCue_ptr->SoundCueGraph = value;}
        }
        ///<summary>The priority of the subtitle.  Defaults to 10000.  Higher values will play instead of lower values.</summary>
        public unsafe float SubtitlePriority {
            get {return SoundCue_ptr->SubtitlePriority;}
            set {SoundCue_ptr->SubtitlePriority = value;}
        }
        static SoundCue() {
            StaticClass = Main.GetClass("SoundCue");
        }
        internal unsafe SoundCue_fields* SoundCue_ptr => (SoundCue_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator SoundCue(IntPtr p) => UObject.Make<SoundCue>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static SoundCue DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static SoundCue New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
