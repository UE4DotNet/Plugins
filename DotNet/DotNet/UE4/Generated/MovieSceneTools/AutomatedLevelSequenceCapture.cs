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
using UE4.MovieSceneTools.Native;
using UE4.MovieSceneCapture;
using UE4.LevelSequence;

namespace UE4.MovieSceneTools {
    ///<summary>Automated Level Sequence Capture</summary>
    public unsafe partial class AutomatedLevelSequenceCapture : UE4.MovieSceneCapture.MovieSceneCapture  {
        ///<summary>A level sequence asset to playback at runtime - used where the level sequence does not already exist in the world.</summary>
        public unsafe SoftObjectPath LevelSequenceAsset {
            get {return AutomatedLevelSequenceCapture_ptr->LevelSequenceAsset;}
            set {AutomatedLevelSequenceCapture_ptr->LevelSequenceAsset = value;}
        }
        public bool bUseCustomStartFrame {
            get {return Main.GetGetBoolPropertyByName(this, "bUseCustomStartFrame"); }
            set {Main.SetGetBoolPropertyByName(this, "bUseCustomStartFrame", value); }
        }
        ///<summary>Frame number to start capturing.</summary>
        public unsafe FrameNumber CustomStartFrame {
            get {return AutomatedLevelSequenceCapture_ptr->CustomStartFrame;}
            set {AutomatedLevelSequenceCapture_ptr->CustomStartFrame = value;}
        }
        public bool bUseCustomEndFrame {
            get {return Main.GetGetBoolPropertyByName(this, "bUseCustomEndFrame"); }
            set {Main.SetGetBoolPropertyByName(this, "bUseCustomEndFrame", value); }
        }
        ///<summary>Frame number to end capturing.</summary>
        public unsafe FrameNumber CustomEndFrame {
            get {return AutomatedLevelSequenceCapture_ptr->CustomEndFrame;}
            set {AutomatedLevelSequenceCapture_ptr->CustomEndFrame = value;}
        }
        ///<summary>The number of extra frames to play before the sequence's start frame, to "warm up" the animation.</summary>
        ///<remarks>
        ///This is useful if your
        ///          animation contains particles or other runtime effects that are spawned into the scene earlier than your capture start frame
        ///</remarks>
        public unsafe int WarmUpFrameCount {
            get {return AutomatedLevelSequenceCapture_ptr->WarmUpFrameCount;}
            set {AutomatedLevelSequenceCapture_ptr->WarmUpFrameCount = value;}
        }
        ///<summary>The number of seconds to wait (in real-time) before we start playing back the warm up frames.  Useful for allowing post processing effects to settle down before capturing the animation.</summary>
        public unsafe float DelayBeforeWarmUp {
            get {return AutomatedLevelSequenceCapture_ptr->DelayBeforeWarmUp;}
            set {AutomatedLevelSequenceCapture_ptr->DelayBeforeWarmUp = value;}
        }
        ///<summary>The number of seconds to wait (in real-time) at shot boundaries.  Useful for allowing post processing effects to settle down before capturing the animation.</summary>
        public unsafe float DelayBeforeShotWarmUp {
            get {return AutomatedLevelSequenceCapture_ptr->DelayBeforeShotWarmUp;}
            set {AutomatedLevelSequenceCapture_ptr->DelayBeforeShotWarmUp = value;}
        }
        ///<summary>Burn in Options</summary>
        public unsafe LevelSequenceBurnInOptions BurnInOptions {
            get {return AutomatedLevelSequenceCapture_ptr->BurnInOptions;}
            set {AutomatedLevelSequenceCapture_ptr->BurnInOptions = value;}
        }
        public bool bWriteEditDecisionList {
            get {return Main.GetGetBoolPropertyByName(this, "bWriteEditDecisionList"); }
            set {Main.SetGetBoolPropertyByName(this, "bWriteEditDecisionList", value); }
        }
        public bool bWriteFinalCutProXML {
            get {return Main.GetGetBoolPropertyByName(this, "bWriteFinalCutProXML"); }
            set {Main.SetGetBoolPropertyByName(this, "bWriteFinalCutProXML", value); }
        }
         //TODO: weak object TWeakObjectPtr<ALevelSequenceActor> LevelSequenceActor
        static AutomatedLevelSequenceCapture() {
            StaticClass = Main.GetClass("AutomatedLevelSequenceCapture");
        }
        internal unsafe AutomatedLevelSequenceCapture_fields* AutomatedLevelSequenceCapture_ptr => (AutomatedLevelSequenceCapture_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator AutomatedLevelSequenceCapture(IntPtr p) => UObject.Make<AutomatedLevelSequenceCapture>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static AutomatedLevelSequenceCapture DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static AutomatedLevelSequenceCapture New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
