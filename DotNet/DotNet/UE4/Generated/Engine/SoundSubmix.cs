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
    ///<summary>Sound Submix</summary>
    public unsafe partial class SoundSubmix : UObject  {

        ///<summary>Add Envelope Follower Delegate</summary>
        public void AddEnvelopeFollowerDelegate(UObject WorldContextObject, byte OnSubmixEnvelopeBP /*TODO: delegate FOnSubmixEnvelopeBP */)  => 
            SoundSubmix_methods.AddEnvelopeFollowerDelegate_method.Invoke(ObjPointer, WorldContextObject, OnSubmixEnvelopeBP);

        ///<summary>Start envelope following the submix output. Register with OnSubmixEnvelope to receive envelope follower data in BP.</summary>
        public void StartEnvelopeFollowing(UObject WorldContextObject)  => 
            SoundSubmix_methods.StartEnvelopeFollowing_method.Invoke(ObjPointer, WorldContextObject);

        ///<summary>Start recording the audio from this submix.</summary>
        public void StartRecordingOutput(UObject WorldContextObject, float ExpectedDuration)  => 
            SoundSubmix_methods.StartRecordingOutput_method.Invoke(ObjPointer, WorldContextObject, ExpectedDuration);

        ///<summary>Start envelope following the submix output. Register with OnSubmixEnvelope to receive envelope follower data in BP.</summary>
        public void StopEnvelopeFollowing(UObject WorldContextObject)  => 
            SoundSubmix_methods.StopEnvelopeFollowing_method.Invoke(ObjPointer, WorldContextObject);

        ///<summary>Finish recording the audio from this submix and export it as a wav file or a USoundWave.</summary>
        public void StopRecordingOutput(UObject WorldContextObject, EAudioRecordingExportType ExportType, string Name, string Path, SoundWave ExistingSoundWaveToOverwrite)  => 
            SoundSubmix_methods.StopRecordingOutput_method.Invoke(ObjPointer, WorldContextObject, ExportType, Name, Path, ExistingSoundWaveToOverwrite);
        ///<summary>Child submixes to this sound mix</summary>
        public ObjectArrayField<SoundSubmix> ChildSubmixes{ get {
            if(ChildSubmixes_store == null) ChildSubmixes_store = new ObjectArrayField<SoundSubmix> (&SoundSubmix_ptr->ChildSubmixes);
            return ChildSubmixes_store;
        } }
        private ObjectArrayField<SoundSubmix> ChildSubmixes_store;

        ///<summary>Parent Submix</summary>
        public unsafe SoundSubmix ParentSubmix {
            get {return SoundSubmix_ptr->ParentSubmix;}
            set {SoundSubmix_ptr->ParentSubmix = value;}
        }
         //TODO: enum ESubmixChannelFormat ChannelFormat
        ///<summary>Submix Effect Chain</summary>
        public ObjectArrayField<SoundEffectSubmixPreset> SubmixEffectChain{ get {
            if(SubmixEffectChain_store == null) SubmixEffectChain_store = new ObjectArrayField<SoundEffectSubmixPreset> (&SoundSubmix_ptr->SubmixEffectChain);
            return SubmixEffectChain_store;
        } }
        private ObjectArrayField<SoundEffectSubmixPreset> SubmixEffectChain_store;

        ///<summary>TODO: Hide this unless Channel Format is ambisonics. Also, worry about thread safety.</summary>
        public unsafe AmbisonicsSubmixSettingsBase AmbisonicsPluginSettings {
            get {return SoundSubmix_ptr->AmbisonicsPluginSettings;}
            set {SoundSubmix_ptr->AmbisonicsPluginSettings = value;}
        }
        ///<summary>The attack time in milliseconds for the envelope follower. Delegate callbacks can be registered to get the envelope value of sounds played with this submix.</summary>
        public unsafe int EnvelopeFollowerAttackTime {
            get {return SoundSubmix_ptr->EnvelopeFollowerAttackTime;}
            set {SoundSubmix_ptr->EnvelopeFollowerAttackTime = value;}
        }
        ///<summary>The release time in milliseconds for the envelope follower. Delegate callbacks can be registered to get the envelope value of sounds played with this submix.</summary>
        public unsafe int EnvelopeFollowerReleaseTime {
            get {return SoundSubmix_ptr->EnvelopeFollowerReleaseTime;}
            set {SoundSubmix_ptr->EnvelopeFollowerReleaseTime = value;}
        }
         //TODO: multicast delegate FOnSubmixRecordedFileDone OnSubmixRecordedFileDone
        static SoundSubmix() {
            StaticClass = Main.GetClass("SoundSubmix");
        }
        internal unsafe SoundSubmix_fields* SoundSubmix_ptr => (SoundSubmix_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator SoundSubmix(IntPtr p) => UObject.Make<SoundSubmix>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static SoundSubmix DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static SoundSubmix New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
